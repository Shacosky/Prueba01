using System.Linq;
using Xamarin.Forms;
using Prueba01.Model;

namespace Prueba01.Views
{
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string catName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"catdetails?name={catName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
        }
    }
}
