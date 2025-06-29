using Microsoft.Maui.Controls;
using ToolTrack.Models;

namespace ToolTrack.Pages
{
    public partial class RegistrarHerramientaPage : ContentPage
    {
        public RegistrarHerramientaPage()
        {
            InitializeComponent();
        }

        private void OnAgregarHerramientaClicked(object sender, EventArgs e)
        {
            DataStore.Herramientas.Add(new Herramienta
            {
                Nombre = NombreEntry.Text,
                Serial = SerialEntry.Text,
                Codigo = CodigoEntry.Text,
                Descripcion = DescripcionEntry.Text,
                Disponible = true
            });

            DisplayAlert("Éxito", "Herramienta registrada", "OK");
            NombreEntry.Text = SerialEntry.Text = CodigoEntry.Text = DescripcionEntry.Text = string.Empty;
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
