using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Services
{
    public class OrderConfigurationFormValuesValidator
    {
        public void ValidateOrderConfigurationFormValues(OrderConfigurationFormValues values, 
            OrderConfigurationFormErrors errors)
        {
            ValidateDriverJobCostPerHour(values, errors);
            ValidateFuelLiterCost(values, errors);
            ValidateAverageFuelConsumption(values, errors);
        }

        public void ValidateDriverJobCostPerHour(OrderConfigurationFormValues values, OrderConfigurationFormErrors errors)
        {
            if (double.TryParse(values.DriverJobCostPerHour, out double driverJobCost))
            {
                if (driverJobCost <= 0)
                {
                    errors.DriverJobCostPerHourError = "Почасовая оплата водителей должна быть положительным числом";
                    return;
                }
            } else
            {
                errors.DriverJobCostPerHourError = "Почасовая оплата водителей должна быть положительным числом";
                return;
            }

            errors.DriverJobCostPerHourError = null;
        }

        public void ValidateAverageFuelConsumption(OrderConfigurationFormValues values, OrderConfigurationFormErrors errors)
        {
            if (double.TryParse(values.AverageFuelConsumptionPerHundredKilometers, out double averageFuelConsumption))
            {
                if (averageFuelConsumption <= 0)
                {
                    errors.AverageFuelConsumptionError = "Средний расход топлива должен быть положительным числом";
                    return;
                }
            } else
            {
               errors.AverageFuelConsumptionError = "Средний расход топлива должен быть положительным числом";
                return;
            }

            errors.AverageFuelConsumptionError = null;
        }

        public void ValidateFuelLiterCost(OrderConfigurationFormValues values, OrderConfigurationFormErrors errors)
        {
            if (double.TryParse(values.AverageFuelConsumptionPerHundredKilometers, out double fuelLiterCost))
            {
                if (fuelLiterCost <= 0)
                {
                    errors.FuelLiterCostError = "Цена за литр топлива должна быть числом";
                    return;
                }
            }
            else
            {
                errors.FuelLiterCostError = "Цена за литр топлива должна быть числом";
                return;
            }

            errors.FuelLiterCostError = null;
        }
    }
}
