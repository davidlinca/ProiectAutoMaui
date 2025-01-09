using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class CarDetailPage : ContentPage
{
    public CarDetailPage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (BindingContext is Car car)
        {
            car.Mark = MarkEntry.Text;
            car.Model = ModelEntry.Text;

            if (int.TryParse(YearEntry.Text, out int year))
            {
                car.Year = year;
            }

            await App.Database.SaveCarAsync(car);
        }

        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (BindingContext is Car car)
        {
            await App.Database.DeleteCarAsync(car);
        }

        await Navigation.PopAsync();
    }
}
