using LiquorStore.Context;
using LiquorStore.DTO;
using LiquorStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using LiquorStore.Entities;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Login")]
        public LoginDTO Login(LoginViewModel vm)
        {
            LoginDTO loginDTO = new LoginDTO();

            var physicalPerson = _context.PhysicalPerson.FirstOrDefault(x => x.CPF == vm.Password);
            var legalPerson = _context.LegalPerson.FirstOrDefault(x => x.CNPJ == vm.Password);

            if(physicalPerson == null && legalPerson == null) throw new Exception("Não foi possível realizar login.");

            if(physicalPerson != null)
            {
                var userPhysicalPerson = _context.Users.FirstOrDefault(x => x.CPFId == physicalPerson.Id);
                if (userPhysicalPerson == null) throw new Exception("Não foi possível realizar login.");

                if (userPhysicalPerson.Email == vm.Login)
                    loginDTO.Identification = vm.Password;
                else
                    throw new Exception("Não foi possível realizar login.");
            }

            if(legalPerson != null)
            {
                var userLegalPerson = _context.Users.FirstOrDefault(x => x.CNPJId == legalPerson.Id);
                if (userLegalPerson == null) throw new Exception("Não foi possível realizar login.");

                if (userLegalPerson.Email == vm.Login)
                    loginDTO.Identification = vm.Password;
                else
                    throw new Exception("Não foi possível realizar login.");
            }

            return loginDTO;
        }

        [HttpPost]
        [Route("RegisterCustomer")]
        public UserDTO RegisterCustomer(UserViewModel vm)
        {
            var cpfExist = _context.PhysicalPerson.FirstOrDefault(x => x.CPF == vm.CPF);
            if (cpfExist != null) throw new Exception("CPF já cadastrado");

            var emailExist = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (emailExist != null) throw new Exception("Email já cadastrado");

            AddressEntity addressEntity = new AddressEntity() { City = vm.City, State = vm.State, Neighborhood = vm.Neighborhood, Street = vm.Street, CreationDate = DateTime.Now };
            _context.Address.Add(addressEntity);

            PhysicalPersonEntity physicalPersonEntity = new PhysicalPersonEntity() { CPF = vm.CPF, Name = vm.Name, BirthDate = vm.BirthDate, CreationDate = DateTime.Now };
            _context.PhysicalPerson.Add(physicalPersonEntity);

            UserEntity userEntity = new UserEntity() { AddressId = addressEntity.Id, CPFId = physicalPersonEntity.Id, ContactNumber = vm.ContactNumber, Email = vm.Email, UserType = Enums.UserType.CUSTOMER, CreationDate = DateTime.Now };
            _context.Users.Add(userEntity);

            UserDTO userDTO = new UserDTO() { AddressId = userEntity.AddressId, CPFId = userEntity.CPFId, ContactNumber = userEntity.ContactNumber, Email = userEntity.Email, UserType = userEntity.UserType };

            return userDTO;
        }

        [HttpPost]
        [Route("RegisterSeller")]
        public UserDTO RegisterSeller(UserViewModel vm)
        {
            var cnpjExist = _context.LegalPerson.FirstOrDefault(x => x.CNPJ == vm.CNPJ);
            if (cnpjExist != null) throw new Exception("CNPJ já cadastrado");

            var emailExist = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (emailExist != null) throw new Exception("Email já cadastrado");

            AddressEntity addressEntity = new AddressEntity() { City = vm.City, State = vm.State, Neighborhood = vm.Neighborhood, Street = vm.Street, CreationDate = DateTime.Now };
            _context.Address.Add(addressEntity);

            LegalPersonEntity legalPersonEntity = new LegalPersonEntity() { CNPJ = vm.CPF, Representative = vm.Representative, CreationDate = DateTime.Now };
            _context.LegalPerson.Add(legalPersonEntity);

            UserEntity userEntity = new UserEntity() { AddressId = addressEntity.Id, CPFId = legalPersonEntity.Id, ContactNumber = vm.ContactNumber, Email = vm.Email, UserType = Enums.UserType.SELLER, CreationDate = DateTime.Now };
            _context.Users.Add(userEntity);

            UserDTO userDTO = new UserDTO() { AddressId = userEntity.AddressId, CPFId = userEntity.CNPJId, ContactNumber = userEntity.ContactNumber, Email = userEntity.Email, UserType = userEntity.UserType };

            return userDTO;
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public UserDTO RegisterAdmin(UserViewModel vm)
        {
            var cnpjExist = _context.LegalPerson.FirstOrDefault(x => x.CNPJ == vm.CNPJ);
            if (cnpjExist != null) throw new Exception("CNPJ já cadastrado");

            var emailExist = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (emailExist != null) throw new Exception("Email já cadastrado");

            AddressEntity addressEntity = new AddressEntity() { City = vm.City, State = vm.State, Neighborhood = vm.Neighborhood, Street = vm.Street, CreationDate = DateTime.Now };
            _context.Address.Add(addressEntity);

            LegalPersonEntity legalPersonEntity = new LegalPersonEntity() { CNPJ = vm.CPF, Representative = vm.Representative, CreationDate = DateTime.Now };
            _context.LegalPerson.Add(legalPersonEntity);

            UserEntity userEntity = new UserEntity() { AddressId = addressEntity.Id, CPFId = legalPersonEntity.Id, ContactNumber = vm.ContactNumber, Email = vm.Email, UserType = Enums.UserType.ADMIN, CreationDate = DateTime.Now };
            _context.Users.Add(userEntity);

            UserDTO userDTO = new UserDTO() { AddressId = userEntity.AddressId, CPFId = userEntity.CNPJId, ContactNumber = userEntity.ContactNumber, Email = userEntity.Email, UserType = userEntity.UserType };

            return userDTO;
        }

        [HttpDelete]
        public bool DeleteUser(UserViewModel vm)
        {
            var cnpjExist = _context.LegalPerson.FirstOrDefault(x => x.CNPJ == vm.CNPJ);
            if (cnpjExist != null) throw new Exception("Usuário ADMIN não recoonhecido, verifique as credenciais.");

            var emailExist = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (emailExist != null) throw new Exception("Usuário ADMIN não recoonhecido, verifique as credenciais.");

            var userAdmin = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (userAdmin.UserType != Enums.UserType.ADMIN) throw new Exception("Usuário não tem permissão para realizar está ação.");

            var user = _context.Users.FirstOrDefault(x => x.Email == vm.Email);
            if (user != null) throw new Exception("Usuário a ser removido não existe ou já foi removido.");

            if(user.CPFId != null)
            {
                var address = _context.Address.FirstOrDefault(x => x.Id == user.AddressId);
                var cpf = _context.PhysicalPerson.FirstOrDefault(x => x.Id == user.CPFId);

                _context.Users.Remove(user);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;

                _context.Address.Remove(address);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;

                _context.PhysicalPerson.Remove(cpf);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;
            }

            if (user.CNPJId != null)
            {
                var address = _context.Address.FirstOrDefault(x => x.Id == user.AddressId);
                var cnpj = _context.LegalPerson.FirstOrDefault(x => x.Id == user.CNPJId);

                _context.Users.Remove(user);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;

                _context.Address.Remove(address);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;

                _context.LegalPerson.Remove(cnpj);
                _context.SaveChanges();
                if (_context.SaveChanges() < 0) return false;
            }

            return true;
        }
    }
}