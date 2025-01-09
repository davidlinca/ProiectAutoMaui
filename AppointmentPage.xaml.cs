using ProiectAutoMaui.Models;

namespace ProiectAutoMaui;

public partial class AppointmentPage : ContentPage
{
    public List<Appointment> Appointments { get; set; }

    public AppointmentPage()
    {
        InitializeComponent();

        Appointments = new List<Appointment>
        {
            new Appointment { AppointmentId = 1, Date = DateTime.Now.AddHours(1), CarId = 101, ServiceId = 201 },
            new Appointment { AppointmentId = 2, Date = DateTime.Now.AddDays(1), CarId = 102, ServiceId = 202 }
        };

        BindingContext = this;
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
