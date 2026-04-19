using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Expenses
{
    internal class ExpenseService : IExpenseService
    {
        private List<Expense> expenses = new();

        public Task<List<Expense>> GetExpenses()
        {
            return Task.FromResult(expenses);
        }

        public Task AddExpense(Expense expense)
        {
            expenses.Add(expense);
            return Task.CompletedTask;
        }

        public Task DeleteExpense(int id)
        {
            var item = expenses.FirstOrDefault(x => x.Id == id);
            if (item != null)
                expenses.Remove(item);

            return Task.CompletedTask;
        }
    }
}