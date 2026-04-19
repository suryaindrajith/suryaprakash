namespace MyExpenses;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
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