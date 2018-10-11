using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using OrderProcessingApp.Models;
using OrderProcessingApp.Services;
using OrderProcessingApp.Views;

namespace OrderProcessingApp
{
    public partial class OrderForm : Form
    {
        private OrderFormValues orderFormValues;
        private OrderFormErrors orderFormErrors;
        private OrderConfigurationFormValues orderConfigurationFormValues;
        private OrderConfigurationFormErrors orderConfigurationFormErrors;
        private Order order;

        public OrderFormValuesValidator OrderFormValuesValidator { get; set; }
        public OrderConfigurationFormValuesValidator OrderConfigurationFormValuesValidator { get;set; }
        public OrderCalculator OrderCalculator { get; set; }
        public OrderConverter OrderConverter { get; set; }

        public OrderForm(OrderFormValuesValidator orderFormValuesValidator, 
            OrderConfigurationFormValuesValidator orderConfigurationFormValuesValidator, 
            OrderCalculator orderCalculator, OrderConverter orderConverter)
        {
            InitializeComponent();
            orderFormValues = new OrderFormValues
            {
                VehicleType = VehicleType.NONE
            };
            orderConfigurationFormValues = new OrderConfigurationFormValues();
            orderFormErrors = new OrderFormErrors();
            orderConfigurationFormErrors = new OrderConfigurationFormErrors();
            this.OrderFormValuesValidator = orderFormValuesValidator;
            this.OrderConfigurationFormValuesValidator = orderConfigurationFormValuesValidator;
            this.OrderCalculator = orderCalculator;
            this.OrderConverter = orderConverter;
        }

        private void NumberOfAdultsInput_TextChanged(object sender, EventArgs e)
        {
            orderFormValues.NumberOfAdults = NumberOfAdultsInput.Text;
        }

        private void NumberOfChildrenInput_TextChanged(object sender, EventArgs e)
        {
            orderFormValues.NumberOfChildren = NumberOfChildrenInput.Text;
        }

        private void WeightOfCargoInput_TextChanged(object sender, EventArgs e)
        {
            orderFormValues.CargoWeight = WeightOfCargoInput.Text;
        }

        private void DistanceInput_TextChanged(object sender, EventArgs e)
        {
            orderFormValues.Distance = DistanceInput.Text;
        }

        private void VehicleTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicleType = (string) VehicleTypePicker.SelectedItem;

            switch (selectedVehicleType)
            {
                case "Легковой автомобиль":
                    orderFormValues.VehicleType = VehicleType.CAR;
                    break;
                case "Автобус":
                    orderFormValues.VehicleType = VehicleType.BUS;
                    break;
                case "Газель":
                    orderFormValues.VehicleType = VehicleType.VAN;
                    break;
                default:
                    orderFormValues.VehicleType = VehicleType.NONE;
                    break;
            }
        }

        private void FuelConsumptionInput_TextChanged(object sender, EventArgs e)
        {
            orderConfigurationFormValues.AverageFuelConsumptionPerHundredKilometers = FuelConsumptionInput.Text;
        }

        private void DriverJobCostPerHourInput_TextChanged(object sender, EventArgs e)
        {
            orderConfigurationFormValues.DriverJobCostPerHour = DriverJobCostPerHourInput.Text;
        }

        private void FuelLiterCostInput_TextChanged(object sender, EventArgs e)
        {
            orderConfigurationFormValues.FuelLiterCost = FuelLiterCostInput.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                HideValidationErrorLabel();
                order = OrderConverter.convertFromFormValues(orderFormValues, orderConfigurationFormValues);
                OrderCalulationResult calulationResult = OrderCalculator.CalculateCost(order);
                OrderCalculationsResultForm calculationsResultForm = new OrderCalculationsResultForm(calulationResult)
                {
                    Visible = true
                };
            }
            else
            {
                System.Console.Out.WriteLine("Form is invalid");
                DisplayValidationErrors();
            }
        }

        private bool IsFormValid()
        {
            OrderFormValuesValidator.ValidateOrderFormValues(orderFormValues, orderFormErrors);
            OrderConfigurationFormValuesValidator.ValidateOrderConfigurationFormValues(orderConfigurationFormValues,
                orderConfigurationFormErrors);
            foreach (PropertyInfo property in orderFormErrors.GetType().GetProperties())
            {
                if (property.GetValue(orderFormErrors) != null)
                {
                    return false;
                }
            }

            foreach (PropertyInfo property in orderConfigurationFormErrors.GetType().GetProperties())
            {
                if (property.GetValue(orderConfigurationFormErrors) != null)
                {
                    return false;
                }
            }

            return true;
        }

        private void DisplayValidationErrors()
        {
            string errorLabel = "";

            foreach (PropertyInfo property in orderFormErrors.GetType().GetProperties())
            {
                if (property.GetValue(orderFormErrors) != null)
                {
                    errorLabel = errorLabel + (string) property.GetValue(orderFormErrors) + "\n";
                } 
            }

            foreach (PropertyInfo property in orderConfigurationFormErrors.GetType().GetProperties())
            {
                if (property.GetValue(orderConfigurationFormErrors) != null)
                {
                    errorLabel = errorLabel + (string)property.GetValue(orderConfigurationFormErrors) + "\n";
                }
            }

            ValidationErrorsLabel.Text = errorLabel;
        }

        private void HideValidationErrorLabel()
        {
            ValidationErrorsLabel.Text = "";
        }

        private void StartTimeDatePicker_ValueChanged(object sender, EventArgs e)
        {
            orderFormValues.StartDate = StartTimeDatePicker.Value;
        }
    }
}
