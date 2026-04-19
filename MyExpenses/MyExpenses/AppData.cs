using System;
using System.Collections.Generic;
using System.Text;
namespace MyExpenses;

public static class AppData
{
    public static List<Expense> Expenses = new List<Expense>();

    public static List<Category> Categories = new List<Category>
    {
        new Category { Name = "Food", Icon = "🍔" },
        new Category { Name = "Transport", Icon = "🚌" },
        new Category { Name = "Shopping", Icon = "🛒" },
        new Category { Name = "Bills", Icon = "💡" }
    };
}
