using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
namespace MyExpenses;

public static class AppData
{
    public static List<Expense> Expenses { get; set; } = new List<Expense>();

    public static List<string> Categories { get; set; } = new List<string>
    {
        "Food",
        "Transport",
        "Shopping",
        "Bills"
    };

    public static void Load()
    {
        var data = Preferences.Get("expenses", "");

        if (!string.IsNullOrEmpty(data))
        {
            Expenses = JsonSerializer.Deserialize<List<Expense>>(data);
        }
    }

    public static void Save()
    {
        var data = JsonSerializer.Serialize(Expenses);
        Preferences.Set("expenses", data);
    }
}