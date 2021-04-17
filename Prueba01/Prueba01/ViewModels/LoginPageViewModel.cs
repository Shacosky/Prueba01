using Prueba01.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Prueba01.ViewModels
{
    public class LoginPageViewModel
    {
        public Command LoginCommand { get; set; }
        public Users users;

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Perfil);
        }

        private void Perfil()
        {
            NavigationPage navigation = new NavigationPage();

            users.FirstName = "Daniel Perez";
            users.AboutMe = "DevOps";
            users.Phone = "942867168";

            //navigation.PushAsync(new Views.App.HomePage());
        }
    }
}
