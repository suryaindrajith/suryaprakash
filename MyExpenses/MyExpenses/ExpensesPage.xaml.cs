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
        var expenses = new List<Expense>
        {
            new Expense { Title = "Bus Fare", Amount = 45, Date = DateTime.Today },
            new Expense { Title = "Lunch", Amount = 120, Date = DateTime.Today },
            new Expense { Title = "Shopping", Amount = 500, Date = DateTime.Today }
        };

        expenseList.ItemsSource = expenses;
    }
}