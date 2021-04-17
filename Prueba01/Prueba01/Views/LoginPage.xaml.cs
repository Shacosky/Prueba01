using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prueba01.Views;
using Prueba01.ViewModels;
using Prueba01.Views.App;

namespace Prueba01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public NavigationPage MainPage { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginPageViewModel();
        }


        private async void Button_goHome(object sender, EventArgs e)
        {
            NavigationPage navPag = new NavigationPage(new Prueba01.AppShell());

            MainPage = navPag;

            await Navigation.PushAsync(MainPage);
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Modificado", "Modificado", "Ok");
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "Finalizado", "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Has Dado click", "ok");

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var decision = "";
            decision = (toggled.IsToggled) ? "Si" : "No";
            DisplayAlert("Modo nocturno", decision, "ok");
        }
    }
}