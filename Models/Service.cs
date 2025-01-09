using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectAutoMaui.Models
{
    public class Service
    {
        [PrimaryKey, AutoIncrement]
        public int ServiceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
