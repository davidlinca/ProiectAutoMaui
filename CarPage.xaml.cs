using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class CarPage : ContentPage
{
    public CarPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        CarListView.ItemsSource = await App.Database.GetCarsAsync();
    }

    private async void OnCarSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Models.Car selectedCar)
        {
            await Navigation.PushAsync(new CarDetailPage
            {
                BindingContext = selectedCar
            });
        }
    }

    private async void OnAddCarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarDetailPage
        {
            BindingContext = new Models.Car()
        });
    }
}
