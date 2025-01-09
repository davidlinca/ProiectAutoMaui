using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class ClientDetailPage : ContentPage
{
    public ClientDetailPage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Client client)
        {
            await App.Database.SaveClientAsync(client);
        }

        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Client client)
        {
            await App.Database.DeleteClientAsync(client);
        }

        await Navigation.PopAsync();
    }
}
