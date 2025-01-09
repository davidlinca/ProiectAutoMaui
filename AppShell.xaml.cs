using ProiectAutoMaui;

namespace ProiectAutoMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ClientDetailPage), typeof(ClientDetailPage));
        Routing.RegisterRoute(nameof(CarDetailPage), typeof(CarDetailPage));
        Routing.RegisterRoute(nameof(ServiceDetailPage), typeof(ServiceDetailPage));
        Routing.RegisterRoute(nameof(AppointmentDetailPage), typeof(AppointmentDetailPage));
    }
}
