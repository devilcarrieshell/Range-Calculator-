using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Calculator_v
{
    public partial class RefuelingTableForm : Form
    {
        public RefuelingTableForm()
        {
            InitializeComponent();
            LoadRefuelingData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadRefuelingData()
        {
            // Add the columns to the DataGridView
            dataGridView.Columns.Add("Date", "Date");
            dataGridView.Columns.Add("Odometer", "Odometer");
            dataGridView.Columns.Add("Refueled", "Refueled");
            dataGridView.Columns.Add("Price", "Price for liter");
            dataGridView.Columns.Add("Refueled Amount", "Refueled Amount");
            dataGridView.Columns.Add("Comment", "Comment");

            // Load the refueling data from the CSV file
            string fileName = "refueling.csv";
            string[] lines = File.ReadAllLines(fileName);

            // Add each refueling record to the DataGridView
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                dataGridView.Rows.Add(fields);
            }
        }
    }
}
