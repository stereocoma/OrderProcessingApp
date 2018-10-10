using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderConfigurationFormValues
    {
        public string DriverJobCostPerHour { get; set; }
        public string AverageFuelConsumptionPerHundredKilometers { get; set; }
        public string FuelLiterCost { get; set; }
    }
}
