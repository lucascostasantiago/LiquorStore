using LiquorStore.Context;
using LiquorStore.DTO;
using LiquorStore.Entities;
using LiquorStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using LiquorStore.Enums;
using System.Collections.Generic;
using LiquorStore.Migrations;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShoppingCartController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ShoppingCartDTO AddProductToCart(ShoppingCartViewModel vm)
        {
            var cpf = _context.PhysicalPerson.FirstOrDefault(x => x.CPF == vm.ClientCPF);
            var client = _context.Users.FirstOrDefault(x => x.CPFId == cpf.Id);
            var product = _context.Products.FirstOrDefault(x => x.ProductCode == vm.ProductCode);

            UserDTO userDTO = new UserDTO() { UserType = client.UserType };

            ValidateUserRole(userDTO);

            ShoppingCartEntity productsEntity = new ShoppingCartEntity() { ClientId = client.Id, ProductId = product.Id, Amount = vm.Amount, CreationDate = DateTime.Now };
            
            _context.ShoppingCarts.Add(productsEntity);

            if (_context.SaveChanges() > 0)
            {
                var entity = _context.ShoppingCarts.FirstOrDefault(productToCart => productToCart.ProductId == product.Id);
                ShoppingCartDTO shoppingCartDTO = new ShoppingCartDTO() { Id = entity.Id, ClientId = entity.ClientId, ProductId = entity.ProductId, Amount = entity.Amount, CreationDate = entity.CreationDate, UpdateDate = entity.UpdateDate };
                return shoppingCartDTO;
            }
            else
                throw new Exception("Não foi possível adicionar um novo produto.");
        }

        [HttpGet]
        public List<ShoppingCartDTO> ListCartProducts(ShoppingCartViewModel vm)
        {
            List<ShoppingCartDTO> shoppingCartDTO = new List<ShoppingCartDTO>();
            var cpf = _context.PhysicalPerson.FirstOrDefault(x => x.CPF == vm.ClientCPF);
            var cliente = _context.Users.FirstOrDefault(x => x.CPFId == cpf.Id);
            var products = _context.ShoppingCarts.Where(x => x.ClientId == cliente.Id);

            foreach (var product in products)
            {
                var productEntity = _context.Products.FirstOrDefault(x => x.Id == product.ProductId);
                var client = _context.Users.FirstOrDefault(x => x.Id == product.ClientId);
                shoppingCartDTO.Add(new ShoppingCartDTO
                {
                    Id = product.Id,
                    ProductId = product.ProductId,
                    ProductCode = productEntity.ProductCode,
                    ProductName = productEntity.ProductName,
                    ClientId = product.ClientId,
                    Amount = product.Amount,
                    Price = productEntity.Price
                });
            }
            return shoppingCartDTO;
        }

        [HttpDelete]
        public bool RemoveProductFromCart(ShoppingCartViewModel vm)
        {
            var cpf = _context.PhysicalPerson.FirstOrDefault(x => x.CPF == vm.ClientCPF);
            var client = _context.Users.FirstOrDefault(x => x.CPFId == cpf.Id);
            UserDTO userDTO = new UserDTO() { UserType = client.UserType };
            ValidateUserRole(userDTO);

            var product = _context.ShoppingCarts.FirstOrDefault(productCart => productCart.Id == vm.Id);
            if (product == null) throw new Exception("Você está tentando um produto que não está no carrinho.");
            _context.ShoppingCarts.Remove(product);
            if (_context.SaveChanges() > 0)
                return true;
            else
                throw new Exception("Não foi possível remover o produto do carrinho.");
        }

        private static void ValidateUserRole(UserDTO dto)
        {
            if(dto.UserType != UserType.CUSTOMER) throw new Exception("Usuário não tem permissão para realizar está ação.");
        }

        [HttpGet("{id}")]
        public ShoppingCartDTO GetById(Guid id)
        {
            var entity = _context.ShoppingCarts.FirstOrDefault(product => product.Id == id);
            if (entity == null) throw new Exception("Produto não existente.");


            ShoppingCartDTO productsDTO = new ShoppingCartDTO()
            {
                Id = entity.Id,
                ProductId = entity.ProductId,
                ClientId = entity.ClientId,
                Amount = entity.Amount,
            };
            
            return productsDTO;
        }
    }
}
