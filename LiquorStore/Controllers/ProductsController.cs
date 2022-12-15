using LiquorStore.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using LiquorStore.ViewModels;
using LiquorStore.Entities;
using LiquorStore.DTO;
using System.Linq;
using System.Collections.Generic;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context) 
        { 
            _context = context;
        }

        [HttpPost]
        public ProductsDTO CreateProduct(ProductsViewModel vm)
        {
            bool validate = false;
            do
            {
                var productCode = Guid.NewGuid().ToString().ToUpper().Substring(0, 8);
                var products = _context.Products.FirstOrDefault(products => products.ProductCode == productCode);
                if (products == null)
                {
                    vm.ProductCode = productCode;
                    validate = true;
                }
            } while (validate == false);

            ProductsEntity productsEntity = new ProductsEntity() { ProductCode = vm.ProductCode, ProductName = vm.ProductName, Price = vm.Price, Amount = vm.Amount, Type = vm.Type, CreationDate = DateTime.Now, };
            _context.Products.Add(productsEntity);

            if (_context.SaveChanges() > 0)
            {
                var entity = _context.Products.FirstOrDefault(product => product.ProductCode == vm.ProductCode);
                ProductsDTO productsDTO = new ProductsDTO() { Id = entity.Id, ProductCode = entity.ProductCode, ProductName = entity.ProductName, Price = entity.Price, Amount = entity.Amount, Type = entity.Type, CreationDate = entity.CreationDate, UpdateDate = entity.UpdateDate };
                return productsDTO;
            }
            else
                throw new Exception("Não foi possível adicionar um novo produto.");
        }

        [HttpGet]
        public List<ProductsDTO> GetProducts()
        {
            List<ProductsDTO> productsDTO = new List<ProductsDTO>();

            var products = _context.Products;
            foreach (var product in products)
            {
                productsDTO.Add(new ProductsDTO
                {
                    Id = product.Id,
                    ProductCode = product.ProductCode,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Amount = product.Amount,
                    Type = product.Type,
                    CreationDate = product.CreationDate,
                    UpdateDate = product.UpdateDate
                });
            }
            return productsDTO;
        }

        [HttpGet("{id}")]
        public ProductsDTO GetById(Guid id)
        {
            var entity = _context.Products.FirstOrDefault(product => product.Id == id);
            if(entity == null) throw new Exception("Produto não existente.");
            ProductsDTO productsDTO = new ProductsDTO() { Id = entity.Id, ProductCode = entity.ProductCode, ProductName = entity.ProductName, Price = entity.Price, Amount = entity.Amount, Type = entity.Type, CreationDate = entity.CreationDate, UpdateDate = entity.UpdateDate };
            return productsDTO;
        }

        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            var product = _context.Products.FirstOrDefault(product => product.Id == id);
            if (product == null) throw new Exception("Você está tentando remover um usuário que não existe.");
            _context.Products.Remove(product);
            if (_context.SaveChanges() > 0)
                return true;
            else
                throw new Exception("Não foi possível remover o produto.");        
        }

        [HttpPut]
        public ProductsDTO Update(ProductsViewModel vm)
        {
            Validate(vm);
            ProductsEntity productsEntity = new ProductsEntity() { Id = vm.Id, Type = vm.Type, Price = vm.Price, Amount = vm.Amount, ProductCode = vm.ProductCode, ProductName = vm.ProductName, CreationDate = vm.CreationDate, UpdateDate = DateTime.Now };

            _context.Update(productsEntity);

            if (_context.SaveChanges() > 0)
            {
                var entity = _context.Products.FirstOrDefault(product => product.Id == vm.Id);
                ProductsDTO productsDTO = new ProductsDTO() { Id = entity.Id, ProductCode = entity.ProductCode, ProductName = entity.ProductName, Price = entity.Price, Amount = entity.Amount, Type = entity.Type, CreationDate = entity.CreationDate, UpdateDate = entity.UpdateDate };
                return productsDTO;
            }
            else
                throw new Exception("Não foi possível atualizar este produto.");
        }

        private static void Validate(ProductsViewModel vm)
        {
            if (vm.Id == Guid.Parse("00000000-0000-0000-0000-000000000000")) throw new Exception("Campo Id inválido!");
            if (vm.ProductName == null) throw new Exception("Campo ProductName inválido!");
            if (vm.ProductCode == null) throw new Exception("Campo ProductCode inválido!");
            if (vm.Price == 0) throw new Exception("Campo Price inválido!");
            if (vm.Type == null) throw new Exception("Campo Type inválido!");
            if (vm.CreationDate == DateTime.Parse("01/01/0001 00:00:00")) throw new Exception("Campo CreationDate inválido!");
        }
    }
}
