using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Range_Calculator_v
{
    public partial class ExpensesForm : Form
    {
        //private readonly FuelData fuelData;
        private  Expense _expense = new Expense();

        public ExpensesForm()
        {
            InitializeComponent();

            //expense types
            expenseTypeComboBox.Items.AddRange(new object[] {
                "Accessories",
                "Spare parts",
                "Car wash",
                "Tax",
                "Parking",
                "Registration",
                "Service",
                "Insurance",
                "Fines",
                "Other expenses"
            });

            dateTimePicker.Value= DateTime.Now;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //to usr dot instead of comma as decimal separator

            // Check if expenses.csv exists, create it if it doesn't
            string fileName = "expenses.csv";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

        }

       

        private void ClearButton_Click(object sender, EventArgs e)// may include in save btn
        {
            ClearForm();
        }

        private void ClearForm()
        {
            odometerTextBox.Clear();
            amountTextBox.Clear();
            expenseTypeComboBox.SelectedIndex = -1;
            commentTextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //Set the expense data 
            _expense.Odometer = int.Parse(odometerTextBox.Text);
            _expense.Amount = double.Parse(amountTextBox.Text);
            _expense.Comment = commentTextBox.Text;
            _expense.Type = expenseTypeComboBox.Text;
            _expense.DateTime = dateTimePicker.Value;

            //Save to CSV file
            string fileName = "expenses.csv";
            string newline = $"{_expense.DateTime}, {_expense.Odometer}, {_expense.Type}, {_expense.Comment}, {_expense.Amount}";
            File.AppendAllLines(fileName, new string[] { newline });


        }
        public class Expense 
        {
            public int Odometer { get; internal set; }
            public double Amount { get; internal set; }
            public string Comment { get; internal set; }
            public string Type { get; internal set; }
            public DateTime DateTime { get; internal set; }
        }
    }
}
