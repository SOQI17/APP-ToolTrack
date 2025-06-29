using Microsoft.Maui.Controls;
using ToolTrack.Models;
using System.Linq;

namespace ToolTrack.Pages
{
    public partial class RegistrarMovimientoPage : ContentPage
    {
        public RegistrarMovimientoPage()
        {
            InitializeComponent();
            HerramientaPicker.ItemsSource = DataStore.Herramientas.Select(h => h.Nombre).ToList();
        }

        private void OnRegistrarMovimientoClicked(object sender, EventArgs e)
        {
            if (HerramientaPicker.SelectedIndex == -1) return;

            string nombreHerramienta = HerramientaPicker.SelectedItem.ToString();
            var herramienta = DataStore.Herramientas.FirstOrDefault(h => h.Nombre == nombreHerramienta);

            if (herramienta != null)
            {
                DataStore.Movimientos.Add(new Movimiento
                {
                    HerramientaNombre = nombreHerramienta,
                    Responsable = ResponsableEntry.Text,
                    Ubicacion = UbicacionEntry.Text,
                    Tipo = TipoPicker.SelectedItem?.ToString() ?? "Ingreso"
                });

                herramienta.Disponible = TipoPicker.SelectedItem?.ToString() == "Ingreso";
                DisplayAlert("Éxito", "Movimiento registrado", "OK");

                HerramientaPicker.SelectedIndex = -1;
                ResponsableEntry.Text = UbicacionEntry.Text = string.Empty;
                TipoPicker.SelectedIndex = -1;
            }
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
