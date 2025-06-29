using Microsoft.Maui.Controls;
using ToolTrack.Models;

namespace ToolTrack.Pages
{
    public partial class VerInventarioPage : ContentPage
    {
        public VerInventarioPage()
        {
            InitializeComponent();
            CargarInventario();
        }

        private void CargarInventario()
        {
            InventarioLayout.Children.Clear();

            foreach (var herramienta in DataStore.Herramientas)
            {
                var disponibilidad = herramienta.Disponible ? "Disponible" : "No disponible";
                InventarioLayout.Children.Add(new Label
                {
                    Text = $"{herramienta.Nombre} - {disponibilidad}"
                });
            }
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
