using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba01.Views.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecursosPage : ContentPage
    {
        public RecursosPage()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elementoSeleccionado = picker.SelectedItem as string;

            DisplayAlert("Seleccion", elementoSeleccionado, "ok");
        }

        private void btnSimulate_Clicked(object sender, EventArgs e)
        {
            progress.ProgressTo(.1, 250, Easing.Linear);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando resutlados", "ok");
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplay.Text = slider.Value.ToString();

        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplayStepper.Text = stepper.Value.ToString();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var decision = "";
            decision = (toggled.IsToggled) ? "Si" : "No";
            DisplayAlert("Modo nocturno", decision, "ok");

        }
    }
}