using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectAutoMaui.Models
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int CarId { get; set; }
        public string Mark { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public int ClientId { get; set; }
    }
}

