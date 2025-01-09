using SQLite;
using ProiectAutoMaui.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProiectAutoMaui.Data
{
    public class AutoMauiDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public AutoMauiDatabase(string dbPath)
        {
            // Inițializăm conexiunea la baza de date
            _database = new SQLiteAsyncConnection(dbPath);

            // Creăm tabelele dacă nu există deja
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Car>().Wait();
            _database.CreateTableAsync<Service>().Wait();
            _database.CreateTableAsync<Appointment>().Wait();
        }

        // CRUD pentru Client
        public Task<List<Client>> GetClientsAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            return _database.Table<Client>().FirstOrDefaultAsync(c => c.ClientId == id);
        }

        public Task<int> SaveClientAsync(Client client)
        {
            if (client.ClientId != 0)
            {
                return _database.UpdateAsync(client); // Actualizează dacă ClientId există
            }
            else
            {
                return _database.InsertAsync(client); // Inserează altfel
            }
        }

        public Task<int> DeleteClientAsync(Client client)
        {
            return _database.DeleteAsync(client);
        }

        // CRUD pentru Car
        public Task<List<Car>> GetCarsAsync()
        {
            return _database.Table<Car>().ToListAsync();
        }

        public Task<Car> GetCarByIdAsync(int id)
        {
            return _database.Table<Car>().FirstOrDefaultAsync(c => c.CarId == id);
        }

        public Task<int> SaveCarAsync(Car car)
        {
            if (car.CarId != 0)
            {
                return _database.UpdateAsync(car); // Actualizează dacă CarId există
            }
            else
            {
                return _database.InsertAsync(car); // Inserează altfel
            }
        }

        public Task<int> DeleteCarAsync(Car car)
        {
            return _database.DeleteAsync(car);
        }

        // CRUD pentru Service
        public Task<List<Service>> GetServicesAsync()
        {
            return _database.Table<Service>().ToListAsync();
        }

        public Task<Service> GetServiceByIdAsync(int id)
        {
            return _database.Table<Service>().FirstOrDefaultAsync(s => s.ServiceId == id);
        }

        public Task<int> SaveServiceAsync(Service service)
        {
            if (service.ServiceId != 0)
            {
                return _database.UpdateAsync(service); // Actualizează dacă ServiceId există
            }
            else
            {
                return _database.InsertAsync(service); // Inserează altfel
            }
        }

        public Task<int> DeleteServiceAsync(Service service)
        {
            return _database.DeleteAsync(service);
        }

        // CRUD pentru Appointment
        public Task<List<Appointment>> GetAppointmentsAsync()
        {
            return _database.Table<Appointment>().ToListAsync();
        }

        public Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            return _database.Table<Appointment>().FirstOrDefaultAsync(a => a.AppointmentId == id);
        }

        public Task<int> SaveAppointmentAsync(Appointment appointment)
        {
            if (appointment.AppointmentId != 0)
            {
                return _database.UpdateAsync(appointment); // Actualizează dacă AppointmentId există
            }
            else
            {
                return _database.InsertAsync(appointment); // Inserează altfel
            }
        }

        public Task<int> DeleteAppointmentAsync(Appointment appointment)
        {
            return _database.DeleteAsync(appointment);
        }
    }
}
