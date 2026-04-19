namespace MyExpenses;

public partial class ExpensesPage : ContentPage
{
    public ExpensesPage()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        expenseList.ItemsSource = null;
        expenseList.ItemsSource = AppData.Expenses;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadData();
    }
    private void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var expense = button?.BindingContext as Expense;

        if (expense != null)
        {
            AppData.Expenses.Remove(expense);
            LoadData();
        }
    }
    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage());
    }

}