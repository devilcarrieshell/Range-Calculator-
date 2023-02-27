using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Range_Calculator_v
{
    public partial class RefuilingForm : Form
    {
        private Refueling _refueling = new Refueling();

        public RefuilingForm()
        {
            InitializeComponent();

            dateTimePicker.Value = DateTime.Now; //set default data
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //to usr dot instead of comma as decimal separator

            // Check if refueling.csv exists, create it if it doesn't
            string fileName = "refueling.csv";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtOdometer.Text, out int odometer) || odometer < 0)
            {
                MessageBox.Show("Please enter a valid odometer reading.");
                return;
            }

            if (!double.TryParse(txtRefueled.Text, out double refueled) || refueled <= 0)
            {
                MessageBox.Show("Please enter a valid amount of fuel refueled.");
                return;
            }

            // Check for other input validation as needed

            // Set the refueling data from the form controls
            _refueling.Odometer = int.Parse(txtOdometer.Text);
            _refueling.Refueled = double.Parse(txtRefueled.Text);
            _refueling.Price = double.Parse(txtPrice.Text);
            _refueling.Comment = txtComment.Text;
            _refueling.DateTime = dateTimePicker.Value;

            // Calculate the total cost
            _refueling.Total = _refueling.Refueled * _refueling.Price;

            // Save the refueling data to a CSV file
            
            string fileName = "refueling.csv";
            const string money = " standard unit";
            string newline = $"{_refueling.DateTime},{_refueling.Odometer + " km"},{_refueling.Refueled + " liters"},{_refueling.Price + money},{_refueling.Total + money},{_refueling.Comment},";
            File.AppendAllLines(fileName, new string[] { newline });

            // Clear the form controls
            txtOdometer.Text = "";
            txtRefueled.Text = "";
            txtPrice.Text = "";
            txtComment.Text = "";
            dateTimePicker.Value = DateTime.Now;

            //Output in label
            amnt.Text = "Amount is:" + _refueling.Total + " Standard units";
            amnt.Tag = 0;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdometer.Text, out int odometer) || odometer < 0)
            {
                MessageBox.Show("Please enter a valid odometer reading.");
                return;
            }

            if (!double.TryParse(txtRefueled.Text, out double refueled) || refueled <= 0)
            {
                MessageBox.Show("Please enter a valid amount of fuel refueled.");
                return;
            }

            // Check for other input validation as needed

            // Set the refueling data from the form controls
            _refueling.Odometer = int.Parse(txtOdometer.Text);
            _refueling.Refueled = double.Parse(txtRefueled.Text);
            _refueling.Price = double.Parse(txtPrice.Text);
            _refueling.Comment = txtComment.Text;
            _refueling.DateTime = dateTimePicker.Value;

            // Calculate the total cost
            _refueling.Total = _refueling.Refueled * _refueling.Price;

            amnt.Text = "Amount is:" + _refueling.Total + " Standard units";
            amnt.Tag = 0;

        }
    }
    class Refueling
    {
        public int Odometer { get; set; }
        public double Refueled { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
    }
}
