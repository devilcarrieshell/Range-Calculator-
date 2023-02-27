using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VehicleRangeCalculator
{
    public partial class Form2 : Form
    {
        private Vehicle _vehicle;

        public Form2()
        {
            InitializeComponent();
            _vehicle = new Vehicle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            averageSpeedTextBox.Text = "50";
            batteryCapacityTextBox.Text = "100";
            energyConsumptionTextBox.Text = "0.2";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double averageSpeed, batteryCapacity, energyConsumption;

            if (double.TryParse(averageSpeedTextBox.Text, out averageSpeed))
            {
                _vehicle.AverageSpeed = averageSpeed;
            }

            if (double.TryParse(batteryCapacityTextBox.Text, out batteryCapacity))
            {
                _vehicle.BatteryCapacity = batteryCapacity;
            }

            if (double.TryParse(energyConsumptionTextBox.Text, out energyConsumption))
            {
                _vehicle.EnergyConsumption = energyConsumption;
            }

            _vehicle.CalculateRange();

            if (_vehicle.VehicleRange != 0)
            {
                vehicleRangeTextBox.ForeColor = Color.Black;
                vehicleRangeTextBox.Text = _vehicle.VehicleRange.ToString();
            }
            else
            {
                vehicleRangeTextBox.ForeColor = Color.Red;
                vehicleRangeTextBox.Text = "Cannot calculate range.";
            }
        }

        private void saveCalculationButton_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var streamWriter = new StreamWriter(saveDialog.FileName))
                {
                    streamWriter.WriteLine(_vehicle.AverageSpeed);
                    streamWriter.WriteLine(_vehicle.BatteryCapacity);
                    streamWriter.WriteLine(_vehicle.EnergyConsumption);
                    streamWriter.WriteLine(_vehicle.VehicleRange);
                }

                MessageBox.Show("Calculation saved successfully!", "Save Calculation");
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (var streamReader = new StreamReader(openDialog.FileName))
                {
                    double averageSpeed, batteryCapacity, energyConsumption, vehicleRange;

                    if (double.TryParse(streamReader.ReadLine(), out averageSpeed))
                    {
                        _vehicle.AverageSpeed = averageSpeed;
                        averageSpeedTextBox.Text = averageSpeed.ToString();
                    }

                    if (double.TryParse(streamReader.ReadLine(), out batteryCapacity))
                    {
                        _vehicle.BatteryCapacity = batteryCapacity;
                        batteryCapacityTextBox.Text = batteryCapacity.ToString();
                    }

                    if (double.TryParse(streamReader.ReadLine(), out energyConsumption))
                    {
                        _vehicle.EnergyConsumption = energyConsumption;
                        energyConsumptionTextBox.Text = energyConsumption.ToString();
                    }

                    if (double.TryParse(streamReader.ReadLine(), out vehicleRange))
                    {
                        _vehicle.VehicleRange = vehicleRange;

                        if (vehicleRange != 0)
                        {
                            vehicleRangeTextBox.ForeColor = Color.Black;
                            vehicleRangeTextBox.Text = vehicleRange.ToString();
                        }
                        else
                        {
                            vehicleRangeTextBox.ForeColor = Color.Red;
                            vehicleRangeTextBox.Text = "Cannot calculate range.";
                        }
                    }
                }

                MessageBox.Show("File loaded successfully!", "Load File");
            }
        }
    }

    public class Vehicle
    {
        public double AverageSpeed { get; set; }
        public double BatteryCapacity { get; set; }
        public double EnergyConsumption { get; set; }
        public double VehicleRange { get; set; }

        public void CalculateRange()
        {
            if (BatteryCapacity != 0 && EnergyConsumption != 0 && AverageSpeed != 0)
            {
                VehicleRange = BatteryCapacity / (EnergyConsumption * AverageSpeed);
            }
        }
    }
}
