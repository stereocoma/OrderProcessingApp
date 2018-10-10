using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderCalulationResult
    {
        public double FullCost { get; set; }
        public double DriversJobCost { get; set; }
        public double FuelCost { get; set; }
        public double VehicleAmortization { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
