using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prueba01;
using System.ComponentModel;

namespace Prueba01.Views.App
{

    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Shell
    {
        public HomePage()
        {
            InitializeComponent();
            //this.Master = new HomePage();
            //Prueba01.App.MasterDet = this;
        }

        public void MyMenu()
        {
            //Detail = new NavigationPage(new Feed());
            //List<Menu> menu = new List<Menu>
            //{
            //    new Menu{Page=new Feed(),MenuTitle="My Profile",MenuDetail="Mi perfil",icon="user.png"},
            //    new Menu{Page=new Feed(),MenuTitle="Messages",MenuDetail="Mensahes",icon="messages.png"},
            //    new Menu{Page=new Feed(),MenuTitle="Contacts",MenuDetail="Contactos",icon="contacts.png"},
            //    new Menu{Page=new Feed(),MenuTitle="Settings",MenuDetail="Configuracion",icon="settings.png"}
            //};

            //ListMenu.ItemsSource = menu;
        }

        public class Menu
        {
            public string MenuTitle { get; set; }
            public string MenuDetail { get; set; }
            public ImageSource icon { get; set; }
            public Page Page { get; set; }
        }

        //private void IrAPaginaAnterior(object sender, EventArgs e)
        //{
        //    Navigation.PopAsync();
        //}

        //private void IrAPaginaSiguiente(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Views.App.Page3());
        //}

        //private void IrAlPerfil(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new PerfilPage());
        //}
    }
}