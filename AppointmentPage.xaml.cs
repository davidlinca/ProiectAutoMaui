using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class AppointmentPage : ContentPage
{
    public AppointmentPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        AppointmentListView.ItemsSource = await App.Database.GetAppointmentsAsync();
    }

    private async void OnAppointmentSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Appointment selectedAppointment)
        {
            await Navigation.PushAsync(new AppointmentDetailPage
            {
                BindingContext = selectedAppointment
            });
        }
    }

    private async void OnAddAppointmentClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppointmentDetailPage
        {
            BindingContext = new Appointment()
        });
    }
}
