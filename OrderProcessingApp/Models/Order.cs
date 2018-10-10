using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class Order
    {
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public double CargoWeight { get; set; }
        public double Distance { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public OrderConfiguration Configuration { get; set; }
    }
}
