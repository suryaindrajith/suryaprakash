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
    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage());
    }

}