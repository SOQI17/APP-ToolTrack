using Microsoft.Maui.Controls;
using ToolTrack.Models;
using System.Linq;

namespace ToolTrack.Pages
{
    public partial class VerMovimientosPage : ContentPage
    {
        public VerMovimientosPage()
        {
            InitializeComponent();
            CargarMovimientos();
        }

        private void CargarMovimientos()
        {
            MovimientosLayout.Children.Clear();

            foreach (var mov in DataStore.Movimientos.OrderByDescending(m => m.Fecha).Take(20))
            {
                MovimientosLayout.Children.Add(new Label
                {
                    Text = $"- {mov.Fecha:g}: {mov.HerramientaNombre} ({mov.Tipo}) - {mov.Responsable} en {mov.Ubicacion}"
                });
            }
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
