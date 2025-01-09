using ProiectAutoMaui.Data;
using System.IO;

namespace ProiectAutoMaui;

public partial class App : Application
{
    private static AutoMauiDatabase? _database;
    public static AutoMauiDatabase Database
    {
        get
        {
            if (_database == null)
            {
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "ProiectAuto.db3"
                );
                _database = new AutoMauiDatabase(dbPath);
            }
            return _database;
        }
    }

    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());
        return window;
    }
}
