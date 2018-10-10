using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderConfigurationFormErrors
    {
        public string DriverJobCostPerHourError { get; set; }
        public string AverageFuelConsumptionError { get; set; }
        public string FuelLiterCostError { get; set; }
    }
}
