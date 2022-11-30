using LiquorStore.Context;
using LiquorStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context) { _context = context; }

        [HttpPost]
        public UserViewModel Create(UserViewModel expense)
        {
            try
            {
                _context.Users.Add(expense);

                if (_context.SaveChanges() > 0)
                    return _context.Users.FirstOrDefault(exp => exp.Id == expense.Id);
                else
                    throw new Exception("Você não conseguiu adicionar um novo usuário.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<UserViewModel> GetExpenses()
            => _context.Users;

        [HttpGet("{id}")]
        public UserViewModel GetById(Guid id)
            => _context.Users.FirstOrDefault(expense => expense.Id == id);

        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            var expense = _context.Users.FirstOrDefault(exp => exp.Id == id);
            if (expense == null)
                throw new Exception("Você está tentando remover um usuário que não existe.");

            _context.Remove(expense);

            return _context.SaveChanges() > 0;
        }

        [HttpPut("{id}")]
        public UserViewModel Update(Guid id, UserViewModel expense)
        {
            try
            {
                if (expense.Id != id)
                    throw new Exception("Você está tentando atualizar um usuário que não existe.");

                _context.Update(expense);

                if (_context.SaveChanges() > 0)
                    return _context.Users.FirstOrDefault(exp => exp.Id == id);
                else
                    return new UserViewModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}