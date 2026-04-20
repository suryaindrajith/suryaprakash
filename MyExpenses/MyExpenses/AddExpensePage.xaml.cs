using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System;

namespace MyExpenses;

public partial class AddExpensePage : ContentPage
{
    Expense editingExpense;

    public AddExpensePage()
    {
        InitializeComponent();
    }

    public AddExpensePage(Expense expense)
    {
        InitializeComponent();

        editingExpense = expense;

        titleEntry.Text = expense.Title;
        amountEntry.Text = expense.Amount.ToString();
        
        categoryPicker.SelectedItem = expense.Category;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string title = titleEntry.Text;

        double.TryParse(amountEntry.Text, out double amount);

        

        string category = categoryPicker.SelectedItem as string;

        if (string.IsNullOrEmpty(title) || category == null)
        {
            await DisplayAlert("Error", "Fill all fields", "OK");
            return;
        }

        if (editingExpense != null)
        {
            editingExpense.Title = title;
            editingExpense.Amount = amount;
           ;
            editingExpense.Category = category;
        }
        else
        {
            Expense newExpense = new Expense
            {
                Title = title,
                Amount = amount,
                
                Category = category
            };

            AppData.Expenses.Add(newExpense);
        }

        AppData.Save();

        await Navigation.PopAsync();
    }
}