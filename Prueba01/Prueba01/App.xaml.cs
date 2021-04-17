using Xamarin.Forms;

namespace Prueba01
{
    public partial class App : Application
    {
        //public static MasterDetailPage MasterDet { get; set; }

        public App()
        {
            InitializeComponent();

            NavigationPage navPag = new NavigationPage(new LoginPage());

            MainPage = navPag;

            //MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
