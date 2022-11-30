using LiquorStore.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LiquorStore.ViewModels;
using System.Linq;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context) { _context = context; }

        [HttpPost]
        public ProductsViewModel Create(ProductsViewModel expense)
        {
            try
            {
                _context.Products.Add(expense);

                if (_context.SaveChanges() > 0)
                    return _context.Products.FirstOrDefault(exp => exp.Id == expense.Id);
                else
                    throw new Exception("Você não conseguiu adicionar um novo usuário.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<ProductsViewModel> GetExpenses()
            => _context.Products;

        [HttpGet("{id}")]
        public ProductsViewModel GetById(Guid id)
            => _context.Products.FirstOrDefault(expense => expense.Id == id);

        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                var expense = _context.Users.FirstOrDefault(exp => exp.Id == id);
                if (expense == null)
                    throw new Exception("Você está tentando remover um usuário que não existe.");

                _context.Remove(expense);

                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ProductsViewModel Update(Guid id, ProductsViewModel expense)
        {
            try
            {
                if (expense.Id != id)
                    throw new Exception("Você está tentando atualizar um usuário que não existe.");

                _context.Update(expense);

                if (_context.SaveChanges() > 0)
                    return _context.Products.FirstOrDefault(exp => exp.Id == id);
                else
                    return new ProductsViewModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
