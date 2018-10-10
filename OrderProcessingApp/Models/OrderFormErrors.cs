using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class OrderFormErrors
    {
        public string NumberOfChildrenError { get; set; }
        public string NumberOfAdultsError { get; set; }
        public string CargoWeightError { get; set; }
        public string DistanceError { get; set; }
        public string NumberOfPassengersError { get; set; }
        public string VehicleTypeError { get; set; }
    }
}
