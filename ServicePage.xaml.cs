using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class ServicePage : ContentPage
{
    public ServicePage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ServiceListView.ItemsSource = await App.Database.GetServicesAsync();
    }

    private async void OnServiceSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Models.Service selectedService)
        {
            await Navigation.PushAsync(new ServiceDetailPage
            {
                BindingContext = selectedService
            });
        }
    }

    private async void OnAddServiceClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServiceDetailPage
        {
            BindingContext = new Models.Service()
        });
    }
}
