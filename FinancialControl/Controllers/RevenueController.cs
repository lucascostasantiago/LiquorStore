using System;
using FinancialControl.Context;
using FinancialControl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using FinancialControl.Enums;

namespace FinancialControl.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RevenueController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RevenueController(AppDbContext context)
        {
            _context = context;
        }

        #region CreateRevenue
        [HttpPost]
        public RevenueModel CreateRevenue(RevenueModel revenue)
        {
            ValidateDate(revenue.Date);

            if (!ValidateType(revenue))
                throw new Exception("Você está inserindo um tipo que não existe.");

            _context.Revenues.Add(revenue);

            if (_context.SaveChanges() > 0)
                return _context.Revenues.FirstOrDefault(rev => rev.Id == revenue.Id);
            else
                throw new Exception("Você não conseguiu adicionar uma nova receita.");
        }
        #endregion

        #region GetRevenues
        [HttpGet]
        public IEnumerable<RevenueModel> GetRevenues()
        {
            return _context.Revenues;
        }
        #endregion

        #region GetRevenueById
        [HttpGet("{id}")]
        public RevenueModel GetRevenueById(int id)
        {
            return _context.Revenues.FirstOrDefault(revenue => revenue.Id == id);
        }
        #endregion

        #region GetRevenueByType
        [HttpGet("type")]
        public List<RevenueModel> GetRevenueByType(RevenueType revenueType)
        {
            return _context.Revenues.Where(revenue => revenueType.Equals(revenueType)).ToList();
        }
        #endregion

        #region GetByInitialDateAndFinalDate
        [HttpGet("Date")]
        public List<RevenueModel> GetFinancialControlByDate(DateTime initialDate, DateTime finalDate)
        {
            List<RevenueModel> revenueModel = new List<RevenueModel>();
            var revenues = _context.Revenues;

            foreach (var revenuesItem in revenues)
            {
                if (finalDate > initialDate)
                {
                    if (DateTime.Now >= initialDate && finalDate <= DateTime.Now)
                    {
                        revenueModel.Add
                        (
                            new RevenueModel()
                            {
                                Id = revenuesItem.Id,
                                Title = revenuesItem.Title,
                                Value = revenuesItem.Value,
                                Description = revenuesItem.Description,
                                Date = revenuesItem.Date,
                                RevenueType = revenuesItem.RevenueType
                            }
                        );
                    }
                }
            }

            return revenueModel;
        }
        #endregion

        #region UpdateRevenue
        [HttpPut("{id}")]
        public RevenueModel UpdateRevenue(int id, RevenueModel revenue)
        {
            ValidateDate(revenue.Date);

            if (!ValidateType(revenue))
                throw new Exception("Você está inserindo um tipo que não existe.");

            if (revenue.Id != id)
                throw new Exception("Você está tentando atualizar a receita errada.");

            _context.Update(revenue);
            if (_context.SaveChanges() > 0)
                return _context.Revenues.FirstOrDefault(rev => rev.Id == id);
            else
                return new RevenueModel();
        }
        #endregion

        #region DeleteRevenue
        [HttpDelete("{id}")]
        public bool DeleteRevenue(int id)
        {
            var revenue = _context.Revenues.FirstOrDefault(rev => rev.Id == id);

            if (revenue == null)
                throw new Exception("Você está tentando deletar uma receita que não existe.");

            _context.Remove(revenue);

            return _context.SaveChanges() > 0;
        }
        #endregion

        #region Utils
        private void ValidateDate(DateTime revenueDate)
        {
            if (revenueDate > DateTime.Now)
                throw new Exception("Não é possível criar uma despesa com a data superior a data atual.");
        }

        private bool ValidateType(RevenueModel revenue)
        {
            var valueRevenueTypeEnum = Enum.GetValues(typeof(RevenueType));

            foreach (var value in valueRevenueTypeEnum)
            {
                if ((int)revenue.RevenueType == (int)value)
                    return true;
            }

            return false;
        }
        #endregion

    }
}
