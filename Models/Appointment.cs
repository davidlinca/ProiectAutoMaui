using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectAutoMaui.Models
{
    public class Appointment
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentId { get; set; }
        public int CarId { get; set; } // ID-ul mașinii
        public int ServiceId { get; set; } // ID-ul serviciului
        public DateTime Date { get; set; }
    }
}
