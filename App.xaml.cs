using mjacomeExamen.VIEWS;

namespace mjacomeExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login()); ;
        }
    }
}
