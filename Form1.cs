using System;
using System.Windows.Forms;

namespace Range_Calculator_v
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the input data from textboxes

            // Enter fuel consumption (L/100km):
            double fuelConsumption;
            if (!double.TryParse(txtFuelConsumption.Text, out fuelConsumption))
            {
                MessageBox.Show("Invalid fuel consumption value.");
                return;
            }

            // Enter trip distance (km):
            double tripDistance;
            if (!double.TryParse(txtTripDistance.Text, out tripDistance))
            {
                MessageBox.Show("Invalid trip distance value.");
                return;
            }

            // Enter vehicle weight (kg)
            double vehicleWeight;
            if (!double.TryParse(txtVehicleWeight.Text, out vehicleWeight))
            {
                MessageBox.Show("Invalid vehicle weight value.");
                return;
            }

            // Enter engine size (L):
            double engineSize;
            if (!double.TryParse(txtEngineSize.Text, out engineSize))
            {
                MessageBox.Show("Invalid engine size value.");
                return;
            }

            // Enter fuel type:
            string fuelType = "";

            // Adjust fuel required based on fuel type
            if (chkPremium.Checked)
            {
                fuelType = "Premium";
            }
            else if (chkDisel.Checked)
            {
                fuelType = "Diesel";
            }

            double fuelRequired = (fuelConsumption / 100) * tripDistance;
            fuelRequired += (vehicleWeight / 1000) * 0.1; // Add 0.1 L per 100 kg of vehicle weight
            fuelRequired += (engineSize / 2);             // Add 0.5 L per liter of engine size

            switch (fuelType.ToLower())
            {
                case "diesel":
                    fuelRequired *= 1.1;
                    break;
                case "premium":
                    fuelRequired *= 0.95;
                    break;
            }

            // Display the output in a message box
            MessageBox.Show("Fuel required: " + fuelRequired.ToString("N2") + " L");
        }


    }
}
