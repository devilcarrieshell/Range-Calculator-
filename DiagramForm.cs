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
using static Range_Calculator_v.ExpensesForm;

namespace Range_Calculator_v
{
    public partial class DiagramForm : Form
    {
        private const string ExpensesFile = "expenses.csv";
        private const string RefuelingFile = "refueling.csv";

        public DiagramForm()
        {
            InitializeComponent();
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            


            int gasStationsCount = 0;
            int expensesCount = 0;
            int kmDriven = 0;
            double litersFilled = 0.0;
            double gasStationsAmount = 0.0;
            double otherExpensesAmount = 0.0;

            // Load data from expenses file
            if (File.Exists(ExpensesFile))
            {
                var expenses = File.ReadAllLines(ExpensesFile);
                expensesCount = expenses.Length - 1; // subtract header row
                foreach (var expense in expenses.Skip(1))
                {
                    var columns = expense.Split(',');
                    if (columns.Length == 5 && columns[2] == "Gas Stations")
                    {
                        gasStationsAmount += double.Parse(columns[4]);
                    }
                    else
                    {
                        otherExpensesAmount += double.Parse(columns[4]);
                    }
                }
            }

            // Load data from refueling file
            if (File.Exists(RefuelingFile))
            {
                var refueling = File.ReadAllLines(RefuelingFile);
                gasStationsCount = refueling.Length - 1; // subtract header row
                foreach (var refill in refueling.Skip(1))
                {
                    var columns = refill.Split(',');
                    if (columns.Length == 6)
                    {
                        kmDriven += int.Parse(columns[1].TrimEnd(' ', 'k', 'm'));
                        litersFilled += double.Parse(columns[2].TrimEnd(' ', 'l'));
                        gasStationsAmount += double.Parse(columns[4]);
                    }
                }
            }

            gasStationsCountLabel.Text = gasStationsCount.ToString();
            expensesCountLabel.Text = expensesCount.ToString();
            kmDrivenLabel.Text = kmDriven.ToString();
            litersFilledLabel.Text = litersFilled.ToString();
            gasStationsAmountLabel.Text = gasStationsAmount.ToString("C2");
            otherExpensesAmountLabel.Text = otherExpensesAmount.ToString("C2");
        }

        private void DiagramForm_Shown(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            int gasStationsCount = 0;
            int expensesCount = 0;
            int kmDriven = 0;
            double litersFilled = 0.0;
            double gasStationsAmount = 0.0;
            double otherExpensesAmount = 0.0;

            // Load data from expenses file
            // ...

            gasStationsCountLabel.Text = gasStationsCount.ToString();
            expensesCountLabel.Text = expensesCount.ToString();
            kmDrivenLabel.Text = kmDriven.ToString();
            litersFilledLabel.Text = litersFilled.ToString();
            gasStationsAmountLabel.Text = gasStationsAmount.ToString("C2");
            otherExpensesAmountLabel.Text = otherExpensesAmount.ToString("C2");
        }

    }
}
