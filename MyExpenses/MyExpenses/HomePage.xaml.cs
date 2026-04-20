namespace MyExpenses;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadStats();
    }

    private void LoadStats()
    {
        totalCountLabel.Text = AppData.Expenses.Count.ToString();

        double total = AppData.Expenses.Sum(x => x.Amount);
        totalAmountLabel.Text = "₹ " + total.ToString();
    }
    private async void OnCategoriesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }

    private async void OnExpensesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExpensesPage());
    }
}