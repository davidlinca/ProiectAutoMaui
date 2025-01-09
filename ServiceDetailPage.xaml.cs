using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class ServiceDetailPage : ContentPage
{
    public ServiceDetailPage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Service service)
        {
            await App.Database.SaveServiceAsync(service);
        }

        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Service service)
        {
            await App.Database.DeleteServiceAsync(service);
        }

        await Navigation.PopAsync();
    }
}