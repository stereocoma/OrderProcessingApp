using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderFormValues
    {
        public string NumberOfAdults { get; set; }
        public string NumberOfChildren { get; set; }
        public string CargoWeight { get; set; }
        public string Distance { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime StartDate { get; set; }
    }
}
