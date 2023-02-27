using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Range_Calculator_v
{
    public partial class CostCalculatorForm : Form
    {
        private Cost _cost = new Cost();
        public CostCalculatorForm()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        }
        private void calculateButton2_Click(object sender, EventArgs e)
        {
            _cost.Distance = int.Parse(distanceTextBox.Text);
            _cost.Consumption = double.Parse(fuelConsumptionTextBox.Text);
            _cost.Price = double.Parse(fuelPriceTextBox.Text);

            //double fuelNeeded = Distance / 100 * fuelConsumption;
            //double tripCost = fuelNeeded * fuelPrice;

            _cost.FuelTotal = _cost.Distance / 100 * _cost.Consumption;
            _cost.CostTotal = _cost.FuelTotal * _cost.Price;

            fuelNeededLabel.Text = _cost.FuelTotal.ToString("0.##") + " L";
            tripCostLabel.Text = _cost.CostTotal.ToString("0.##") + " ";
            //Output in label
        }
        class Cost
        {
            public int Distance { get; set; }
            public double Consumption { get; set; }
            public double Price { get; set; }
            public double FuelTotal { get; set; }
            public double CostTotal { get; set; }

        }
    }
}

