namespace MyExpenses;

public partial class ExpensesPage : ContentPage
{
    Expense selectedExpense; 

    public ExpensesPage()
    {
        InitializeComponent();
        AppData.Load();
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
            AppData.Save();
            LoadData();
        }
    }

    private async void OnEditClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var expense = button?.CommandParameter as Expense;

        if (expense == null)
            return;

        
        selectedExpense = expense;

     
        await Navigation.PushAsync(new AddExpensePage(expense));
    }

    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage());
    }
}