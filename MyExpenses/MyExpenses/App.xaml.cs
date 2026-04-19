using Microsoft.Extensions.DependencyInjection;

namespace MyExpenses
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new HomePage();
            MainPage = new NavigationPage(new HomePage());
        }

        
    }
}