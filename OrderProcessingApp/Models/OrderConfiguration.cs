using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderConfiguration
    {
        public double DriverJobCostPerHour { get; set; }
        public double AverageFuelConsumptionPerHundredKilometers { get; set; }
        public double FuelLiterCost { get; set; }
    }
}
