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
            // Create a new instance of RangeCalculator
            RangeCalculator calculator = new RangeCalculator();

            // Set the properties of the calculator object from the input data
            calculator.FuelConsumption = ParseDouble(txtFuelConsumption.Text);
            calculator.TripDistance = ParseDouble(txtTripDistance.Text);
            calculator.VehicleWeight = ParseDouble(txtVehicleWeight.Text);
            calculator.EngineSize = ParseDouble(txtEngineSize.Text);
            

            if (chkPremium.Checked)
            {
                calculator.FuelType = FuelType.Premium;
            }
            else if (chkDisel.Checked)
            {
                calculator.FuelType = FuelType.Diesel;
            }
            else
            {
                calculator.FuelType = FuelType.Regular; // also tomorrow I'll add more checkbox for rest tipes of fuel))
            }
            if (calculator.TripDistance > 200)
            {
                MessageBox.Show("Please be careful on the road. The destination is far away. " +
                    "Keep in mind that for safety on the road, it is advisable to take breaks every 150 km.");
            }

            // Calculate the fuel required using the RangeCalculator object
            double fuelRequired = calculator.CalculateFuelRequired();
            

            // Display the output in a message box
            MessageBox.Show("Fuel required: " + fuelRequired.ToString("N2") + " L");
        }

        private double ParseDouble(string text)
        {
            double value;
            if (!double.TryParse(text, out value))
            {
                MessageBox.Show("Invalid value: " + text);
                throw new ArgumentException("Invalid value: " + text);
            }
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default values for the input fields
            txtFuelConsumption.Text = "8,0";
            txtTripDistance.Text = "100,0";
            txtVehicleWeight.Text = "1500,0";
            txtEngineSize.Text = "2,0";
        }
    }

    public enum FuelType
    {
        Regular,
        Premium,
        Diesel
    }

    public class RangeCalculator
    {
        public double FuelConsumption { get; set; }
        public double TripDistance { get; set; }
        public double VehicleWeight { get; set; }
        public double EngineSize { get; set; }
        public FuelType FuelType { get; set; }

        

    public double CalculateFuelRequired()
        {
            // Validation commands

            if (FuelConsumption <= 0)
            {
                throw new ArgumentException("Invalid fuel consumption value: " + FuelConsumption);
            }
            if (TripDistance <= 0)
            {
                throw new ArgumentException("Invalid trip distance value: " + TripDistance);
            }
            if (VehicleWeight <= 5)
            {
                throw new ArgumentException("Invalid Vehicle Weight value: " + VehicleWeight);
            }
            if (EngineSize <0)
            {
                throw new ArgumentException("Invalid engine size value: " + EngineSize);
            }
            

            double fuelRequired = (FuelConsumption / 100) * TripDistance;
            fuelRequired += (VehicleWeight / 1000) * 0.1; // Add 0.1 L per 100 kg of vehicle weight
            fuelRequired += (EngineSize / 2);             // Add 0.5 L per liter of engine size

            switch (FuelType)
            {
                case FuelType.Diesel:
                    fuelRequired *= 1.1;
                    break;
                case FuelType.Premium:
                    fuelRequired *= 0.95;
                    break;
            }

            return fuelRequired;
        }
    }
}
