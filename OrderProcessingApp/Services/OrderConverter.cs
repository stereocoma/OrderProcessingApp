using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Services
{
    public class OrderConverter
    {
        public Order convertFromFormValues(OrderFormValues orderForm, OrderConfigurationFormValues orderConfigurationForm)
        {
            return new Order()
            {
                CargoWeight = double.Parse(orderForm.CargoWeight),
                Distance = double.Parse(orderForm.Distance),
                NumberOfAdults = int.Parse(orderForm.NumberOfAdults),
                NumberOfChildren = int.Parse(orderForm.NumberOfChildren),
                StartTime = orderForm.StartDate,
                VehicleType = orderForm.VehicleType,
                Configuration = new OrderConfiguration()
                {
                    AverageFuelConsumptionPerHundredKilometers 
                        = double.Parse(orderConfigurationForm.AverageFuelConsumptionPerHundredKilometers),
                    DriverJobCostPerHour = double.Parse(orderConfigurationForm.DriverJobCostPerHour),
                    FuelLiterCost = double.Parse(orderConfigurationForm.FuelLiterCost)
                }
            };
        }
    }
}
