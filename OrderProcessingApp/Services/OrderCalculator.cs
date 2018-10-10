using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Services
{
    public class OrderCalculator
    {
        private const int AVERAGE_CAR_SPEED = 80;
        private const int AVERAGE_VAN_SPEED = 70;
        private const int AVERAGE_BUS_SPEED = 60;
        private const int MAX_HOURS_PER_DAY = 9;

        public OrderCalulationResult CalculateCost(Order order)
        {
            OrderConfiguration orderConfiguration = order.Configuration;
            double hoursSpent = CalculateHoursSpent(order);
            double driversJobCost = CalculateCostOfDriversJob(hoursSpent, orderConfiguration.DriverJobCostPerHour);
            double fuelCost = CalculateFuelCost(order.Distance, orderConfiguration.FuelLiterCost,
                orderConfiguration.AverageFuelConsumptionPerHundredKilometers);
            double vehicleAmortization = CalculateVehicleAmortization(fuelCost);
            double fullCost = driversJobCost + fuelCost + vehicleAmortization;

            OrderCalulationResult orderCalulationResult = new OrderCalulationResult
            {
                EndTime = order.StartTime.AddHours(hoursSpent),
                DriversJobCost = driversJobCost,
                FuelCost = fuelCost,
                VehicleAmortization = vehicleAmortization,
                FullCost = fullCost
            };

            return orderCalulationResult;
        }

        private double CalculateHoursSpent(Order order)
        {
            double averageSpeed = GetAverageSpeedForVehicleType(order.VehicleType);
            double hoursSpent = 0;

            double remainingDistance = order.Distance;

            while (remainingDistance > 0)
            {
                if (CanDistanceBeCoveredWithinTimeLimit(remainingDistance, averageSpeed))
                {
                    hoursSpent += CalculateTime(remainingDistance, averageSpeed);
                    break;
                }
                else
                {
                    hoursSpent += MAX_HOURS_PER_DAY;
                    remainingDistance -= CalculateCoveredDistance(averageSpeed, hoursSpent);
                }
            }

            return hoursSpent;
        }

        private double GetAverageSpeedForVehicleType(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.BUS:
                    return (AVERAGE_BUS_SPEED + AVERAGE_BUS_SPEED - 10) / 2;
                case VehicleType.CAR:
                    return (AVERAGE_CAR_SPEED + AVERAGE_CAR_SPEED - 10) / 2;
                case VehicleType.VAN:
                    return (AVERAGE_VAN_SPEED + AVERAGE_VAN_SPEED - 10) / 2;
                default:
                    return (AVERAGE_CAR_SPEED + AVERAGE_CAR_SPEED - 10) / 2;
            }
        }

        private bool CanDistanceBeCoveredWithinTimeLimit(double distance, double averageSpeed)
        {
            return CalculateTime(distance, averageSpeed) < MAX_HOURS_PER_DAY;
        }

        private double CalculateTime(double distance, double averageSpeed)
        {
            return distance / averageSpeed;
        }

        private double CalculateCoveredDistance(double averageSpeed, double hoursSpent)
        {
            return averageSpeed * hoursSpent;
        }

        private double CalculateFuelCost(double coveredDistance, double fuelLiterCost, 
            double averageFuelConsumptionPerHundredKilometers)
        {
            return (coveredDistance / 100) * averageFuelConsumptionPerHundredKilometers * fuelLiterCost;
        }

        private double CalculateCostOfDriversJob(double hoursSpent, double driverJobCostPerHour)
        {
            return 2 * hoursSpent * driverJobCostPerHour;
        }

        private double CalculateVehicleAmortization(double fuelCost)
        {
            return fuelCost * 0.25;
        }
    }
}
