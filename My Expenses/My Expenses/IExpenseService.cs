using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyExpenses
{
    internal interface IExpenseService
    {
        Task<List<Expense>> GetExpenses();
        Task AddExpense(Expense expense);
        Task DeleteExpense(int id);
    }
}