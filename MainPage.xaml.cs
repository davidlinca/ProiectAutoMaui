namespace ProiectAutoMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnClientsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientPage());
    }

    private async void OnCarsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarPage());
    }

    private async void OnServicesButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicePage());
    }

    private async void OnAppointmentsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppointmentPage());
    }
}
