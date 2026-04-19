namespace MyExpenses;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        categoryList.ItemsSource = null;
        categoryList.ItemsSource = AppData.Categories;
    }
}