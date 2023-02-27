using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRangeCalculator;

namespace Range_Calculator_v
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();

            fuelForm = new Form1();
            electricForm = new Form2();
            hybridForm = new Form3();
            refuelForm = new RefuilingForm();
            tableForm = new RefuelingTableForm();
            reminder = new ReminderForm();
            expensesForm = new ExpensesForm();
            calculatorForm = new CalculatorForm();
            encomesForm= new EncomesForm();
            diagramForm= new DiagramForm();
            statsForm= new StatsForm();
            expensesTabelForm=new ExpensesTabelForm();
            encomeTabelForm=new EncomeTabelForm();
            costCalculatorForm = new CostCalculatorForm();
            distanceCalculatorForm = new DistanceCalculatorForm();
            consumptionCalculatorForm = new ConsumptionCalculatorForm();

        }
        Form1 fuelForm;
        Form2 electricForm;
        Form3 hybridForm;
        RefuilingForm refuelForm;
        RefuelingTableForm tableForm;
        ReminderForm reminder;
        ExpensesForm expensesForm;
        CalculatorForm calculatorForm;
        EncomesForm encomesForm;
        DiagramForm diagramForm;
        StatsForm statsForm;
        ExpensesTabelForm expensesTabelForm;
        EncomeTabelForm encomeTabelForm;
        CostCalculatorForm costCalculatorForm;
        DistanceCalculatorForm distanceCalculatorForm;
        ConsumptionCalculatorForm consumptionCalculatorForm;

        private void btn_fuel_Click(object sender, EventArgs e)
        {
            fuelForm.Show();
        }

        private void btn_el_Click(object sender, EventArgs e)
        {
            electricForm.Show();
        }

        private void btn_hyb_Click(object sender, EventArgs e)
        {
            hybridForm.Show();
        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            refuelForm.Show();
        }

        private void Refs_btn_Click(object sender, EventArgs e)
        {
            tableForm.Show(); 
        }

        private void rem_btn_Click(object sender, EventArgs e)
        {
            reminder.Show();
        }

        private void Exp_btn_Click(object sender, EventArgs e)
        {
            expensesForm.Show();
        }

        private void encome_btn_Click(object sender, EventArgs e)
        {
            encomesForm.Show();
        }

        private void diagram_btn_Click(object sender, EventArgs e)
        {
            diagramForm.Show();
        }

        private void ststs_btn_Click(object sender, EventArgs e)
        {
            statsForm.Show();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            costCalculatorForm.Show();
        }

        private void ExpTb_btn_Click(object sender, EventArgs e)
        {
            expensesTabelForm.Show();
        }

        private void EnTb_btn_Click(object sender, EventArgs e)
        {
            encomeTabelForm.Show();
        }

        public DateTime? NextReminder
        {
            get { return lblNextReminder.Tag as DateTime?; }
            set
            {
                if (value.HasValue)
                {
                    lblNextReminder.Text = $"Next reminder: {value.Value:dd/MM/yyyy HH:mm}";
                    lblNextReminder.Tag = value;
                }
                else
                {
                    lblNextReminder.Text = "Next reminder: None";
                    lblNextReminder.Tag = null;
                }
            }
        }
    }
}
