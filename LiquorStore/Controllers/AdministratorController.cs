using LiquorStore.Context;
using LiquorStore.DTO;
using LiquorStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LiquorStore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdministratorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public List<SalesHistoryDTO> GetProductsByDate(SalesHistoryViewModel vm)
        {
            List<SalesHistoryDTO> salesHistoryViewDTO = new List<SalesHistoryDTO>();

            var products = _context.SalesHistory;

            foreach (var item in products)
            {
                if(item.CreationDate >= vm.InitialDate && item.CreationDate <= vm.FinalDate)
                {
                    var productName = _context.Products.FirstOrDefault(x => x.Id == item.ProductId);
                    salesHistoryViewDTO.Add(new SalesHistoryDTO
                    {
                        ProductId = item.Id,
                        Amount = item.Amount,
                        Price = item.Price,
                        ProductName = productName.ProductName
                    });
                }
            }

            return salesHistoryViewDTO;
        }

        [HttpGet]
        public List<SalesHistoryDTO> GetProducts()
        {
            List<SalesHistoryDTO> salesHistoryViewDTO = new List<SalesHistoryDTO>();

            var products = _context.SalesHistory;

            foreach (var item in products)
            {
                var productName = _context.Products.FirstOrDefault(x => x.Id == item.ProductId);
                salesHistoryViewDTO.Add(new SalesHistoryDTO
                {
                    ProductId = item.Id,
                    Amount = item.Amount,
                    Price = item.Price,
                    ProductName = productName.ProductName
                });
            }

            return salesHistoryViewDTO;
        }
    }
}
