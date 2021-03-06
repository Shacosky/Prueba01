using System;
using System.Linq;
using Xamarin.Forms;
using Prueba01.Data;
using Prueba01.Model;

namespace Prueba01.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class ElephantDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public ElephantDetailPage()
        {
            InitializeComponent();
        }

        void LoadAnimal(string name)
        {
            try
            {
                Animal animal = ElephantData.Elephants.FirstOrDefault(a => a.Name == name);
                BindingContext = animal;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }
    }
}
