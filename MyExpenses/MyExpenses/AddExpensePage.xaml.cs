namespace MyExpenses;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string title = titleEntry.Text;
        double amount = double.Parse(amountEntry.Text);
        DateTime date = datePicker.Date ?? DateTime.Now;

        var newExpense = new Expense
        {
            Title = title,
            Amount = amount,
            Date = date
        };

        await DisplayAlert("Saved", "Expense added successfully!", "OK");

        await Navigation.PopAsync(); // go back
    }
}