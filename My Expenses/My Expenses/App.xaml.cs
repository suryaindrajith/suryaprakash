using Microsoft.Extensions.DependencyInjection;

namespace My_Expenses
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new HomePage();
        
        }

       
    }
}
