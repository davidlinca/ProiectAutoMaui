using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class AppointmentDetailPage : ContentPage
{
    public AppointmentDetailPage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (BindingContext is Appointment appointment)
        {
            await App.Database.SaveAppointmentAsync(appointment);
        }

        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (BindingContext is Appointment appointment)
        {
            await App.Database.DeleteAppointmentAsync(appointment);
        }

        await Navigation.PopAsync();
    }
}
