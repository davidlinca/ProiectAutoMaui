using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class ClientPage : ContentPage
{
    public ClientPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ClientListView.ItemsSource = await App.Database.GetClientsAsync();
    }

    private async void OnClientSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Models.Client selectedClient)
        {
            await Navigation.PushAsync(new ClientDetailPage
            {
                BindingContext = selectedClient
            });
        }
    }

    private async void OnAddClientClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientDetailPage
        {
            BindingContext = new Models.Client()
        });
    }
}
