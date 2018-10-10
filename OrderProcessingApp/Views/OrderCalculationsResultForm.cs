using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Views
{
    public partial class OrderCalculationsResultForm : Form
    {
        public OrderCalculationsResultForm(OrderCalulationResult orderCalulationResult)
        {
            InitializeComponent();
            EndTimeLabelResult.Text = orderCalulationResult.EndTime.ToString("dd-MM-yyyy HH:mm");
            FuelCostCalculationResultLabel.Text = String.Format("{0: 0.00}", orderCalulationResult.FuelCost);
            DriversJobCostCalculationResultLabel.Text = String.Format("{0: 0.00}", orderCalulationResult.DriversJobCost);
            FullCostCalculationResultLabel.Text = String.Format("{0: 0.00}", orderCalulationResult.FullCost);
            VehicleAmortizationCalculationResultLabel.Text = String.Format("{0: 0.00}", 
                orderCalulationResult.VehicleAmortization);
        }
    }
}
