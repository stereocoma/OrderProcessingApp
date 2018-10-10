using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Services
{
    public class OrderFormValuesValidator
    {
        public void ValidateOrderFormValues(OrderFormValues orderFormValues, OrderFormErrors orderFormErrors)
        {
            ValidateNumberOfChildrenAndNumberOfAdults(orderFormValues, orderFormErrors);
            ValidateDistance(orderFormValues, orderFormErrors);
            ValidateCargoWeight(orderFormValues, orderFormErrors);
            ValidateVehicleType(orderFormValues, orderFormErrors);
        }

        public void ValidateNumberOfChildrenAndNumberOfAdults(OrderFormValues orderFormValues, 
            OrderFormErrors orderFormErrors)
        {
            string numberOfChildren = orderFormValues.NumberOfChildren;
            string numberOfAdults = orderFormValues.NumberOfAdults;

            CheckIfNumberOfChildrenAndNumberOfAdultsAreIntegers(numberOfChildren, numberOfAdults, orderFormErrors);

            if (orderFormErrors.NumberOfAdultsError == null && orderFormErrors.NumberOfChildrenError == null)
            {
                int.TryParse(numberOfChildren, out int numberOfChildrenParsed);
                int.TryParse(numberOfAdults, out int numberOfAdultsParsed);

                if (numberOfChildrenParsed != 0 && numberOfAdultsParsed == 0)
                {
                    orderFormErrors.NumberOfAdultsError = "При наличии детей должен быть хотя " +
                        "бы 1 сопровождающий взрослый";
                    return;
                } 

                if ((numberOfChildrenParsed + numberOfAdultsParsed) > orderFormValues.VehicleType.GetPassengersCapacity())
                {
                    orderFormErrors.NumberOfPassengersError = "Количество пассажиров превышает максимальную вместимость " +
                        "транспорта";
                    return;
                }

                orderFormErrors.NumberOfAdultsError = null;
                orderFormErrors.NumberOfChildrenError = null;
                orderFormErrors.NumberOfPassengersError = null;
            }
        }

        private void CheckIfNumberOfChildrenAndNumberOfAdultsAreIntegers(string numberOfChildren, string numberOfAdults,
            OrderFormErrors orderFormErrors)
        {
            if (!ValidationUtils.IsInteger(numberOfChildren))
            {
                orderFormErrors.NumberOfChildrenError = "Количество детей должно быть целым числом";
            } else
            {
                orderFormErrors.NumberOfChildrenError = null;
            }

            if (!ValidationUtils.IsInteger(numberOfAdults)) {
                orderFormErrors.NumberOfAdultsError = "Количество взрослых должно быть целым числом";
            } else
            {
                orderFormErrors.NumberOfAdultsError = null;
            }
        }

        public void ValidateDistance(OrderFormValues orderFormValues, OrderFormErrors orderFormErrors)
        {
            if (!ValidationUtils.IsDouble(orderFormValues.Distance))
            {
                orderFormErrors.DistanceError = "Расстояние должно быть числом";
            } else
            {
                double.TryParse(orderFormValues.Distance, out double parsedDistance);

                if (parsedDistance <= 0)
                {
                    orderFormErrors.DistanceError = "Расстояние должно быть положительным числом";
                    return;
                }

                orderFormErrors.DistanceError = null;
            }
        }

        public void ValidateCargoWeight(OrderFormValues orderFormValues, OrderFormErrors orderFormErrors)
        {
            if (!ValidationUtils.IsInteger(orderFormValues.CargoWeight))
            {
                orderFormErrors.CargoWeightError = "Масса груза должна быть целым положительным числом";
                return;
            }

            int.TryParse(orderFormValues.CargoWeight, out int cargoWeight);

            if (cargoWeight <=0)
            {
                orderFormErrors.CargoWeightError = "Масса груза должна быть целым положительным числом";
                return;
            }

            if (cargoWeight > orderFormValues.VehicleType.GetCargoWeightCapacity())
            {
                orderFormErrors.CargoWeightError = "Масса груза превышает максимальную для данного транспорта";
                return;
            }

            orderFormErrors.CargoWeightError = null;
        }

        private void ValidateVehicleType(OrderFormValues orderFormValues, OrderFormErrors orderFormErrors)
        {
            if (orderFormValues.VehicleType.Equals(VehicleType.NONE))
            {
                orderFormErrors.VehicleTypeError = "Тип транспорта не указан";
                return;
            }

            orderFormErrors.VehicleTypeError = null;
        }
    }
}
