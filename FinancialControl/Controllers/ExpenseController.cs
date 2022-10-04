using FinancialControl.Context;
using FinancialControl.Enums;
using FinancialControl.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExpenseController(AppDbContext context) { _context = context; }

        #region CreateExpense
        [HttpPost]
        public ExpenseModel CreateExpense(ExpenseModel expense)
        {
            ValidateDate(expense.Date);

            if (!ValidateType(expense))
                throw new Exception("Você está inserindo um tipo que não de despesa não existente.");

            _context.Expenses.Add(expense);

            if (_context.SaveChanges() > 0)
                return _context.Expenses.FirstOrDefault(exp => exp.Id == expense.Id);
            else
                throw new Exception("Você não conseguiu adicionar uma nova despesa.");
        }
        #endregion

        #region GetExpenses
        [HttpGet]
        public IEnumerable<ExpenseModel> GetExpenses()
        {
            return _context.Expenses;
        }
        #endregion

        #region GetExpenseById
        [HttpGet("{id}")]
        public ExpenseModel GetExpenseById(int id)
        {
            return _context.Expenses.FirstOrDefault(expense => expense.Id == id);
        }
        #endregion

        #region GetExpenseByType
        [HttpGet("type")]
        public List<ExpenseModel> GetExpenseByType(ExpenseType expenseType)
        {
            return _context.Expenses.Where(expense => expenseType.Equals(expenseType)).ToList();
        }
        #endregion

        #region GetByInitialDateAndFinalDate
        [HttpGet("Date")]
        public List<ExpenseModel> GetFinancialControlByDate(DateTime initialDate, DateTime finalDate)
        {
            List<ExpenseModel> expenseModel = new List<ExpenseModel>();
            var expenses = _context.Expenses;

            foreach (var expenseItem in expenses)
            {
                if (finalDate > initialDate)
                {
                    if (DateTime.Now >= initialDate && finalDate <= DateTime.Now)
                    {
                        expenseModel.Add
                        (
                            new ExpenseModel()
                            {
                                Id = expenseItem.Id,
                                Title = expenseItem.Title,
                                Value = expenseItem.Value,
                                Description = expenseItem.Description,
                                Date = expenseItem.Date,
                                ExpenseType = expenseItem.ExpenseType
                            }
                        );
                    }
                }
            }

            return expenseModel;
        }
        #endregion

        #region UpdateExpense
        [HttpPut("{id}")]
        public ExpenseModel UpdateExpense(int id, ExpenseModel expense)
        {
            ValidateDate(expense.Date);

            if (!ValidateType(expense))
                throw new Exception("Você está inserindo um tipo que não existe.");

            if (expense.Id != id)
                throw new Exception("Você está tentando atualizar a despesa errada.");

            _context.Update(expense);

            if (_context.SaveChanges() > 0)
                return _context.Expenses.FirstOrDefault(exp => exp.Id == id);
            else
                return new ExpenseModel();
        }
        #endregion

        #region DeleteExpense
        [HttpDelete("{id}")]
        public bool DeleteExpense(int id)
        {
            var expense = _context.Expenses.FirstOrDefault(exp => exp.Id == id);
            if (expense == null)
                throw new Exception("Você está tentando deletar uma despesa que não existe.");

            _context.Remove(expense);

            return _context.SaveChanges() > 0;
        }
        #endregion

        #region Utils
        private void ValidateDate(DateTime expenseDate)
        {
            if (expenseDate > DateTime.Now)
                throw new Exception("Não é possível criar uma despesa com a data superior a data atual.");
        }

        private bool ValidateType(ExpenseModel expense)
        {
            var valueExpenseTypeEnum = Enum.GetValues(typeof(ExpenseType));

            foreach (var value in valueExpenseTypeEnum)
            {
                if ((int)expense.ExpenseType == (int)value)
                    return true;
            }

            return false;
        }
        #endregion
    }
}