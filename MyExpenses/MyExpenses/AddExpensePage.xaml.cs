namespace MyExpenses;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage()
    {
        InitializeComponent();

        categoryPicker.ItemsSource = AppData.Categories;
        categoryPicker.ItemDisplayBinding = new Binding("Name");

    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string title = titleEntry.Text;
        double amount = double.Parse(amountEntry.Text);
        DateTime date = datePicker.Date ?? DateTime.Now;

        var selectedCategory = categoryPicker.SelectedItem as Category;

        var newExpense = new Expense
        {
            Title = title,
            Amount = amount,
            Date = date,
            CategoryName = selectedCategory?.Name
        };
        AppData.Expenses.Add(newExpense);

        await DisplayAlert("Saved", "Expense added successfully!", "OK");

        await Navigation.PopAsync(); // go back
    }
}