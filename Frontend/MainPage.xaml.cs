namespace ToolTrack;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RegistrarHerramientaPage");
    }

    private async void OnMovimientoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RegistrarMovimientoPage");
    }

    private async void OnMovimientosClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///VerMovimientosPage");
    }

    private async void OnDescargarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Descarga", "Funcionalidad aún no implementada", "OK");
    }

    private async void OnInventarioClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///VerInventarioPage");
    }
}
