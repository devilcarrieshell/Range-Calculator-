using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Calculator_v
{
    //Calculator setting mode form 
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();

            costCalculatorForm = new CostCalculatorForm();
            distanceCalculatorForm = new DistanceCalculatorForm();
            consumptionCalculatorForm= new ConsumptionCalculatorForm();
        }

        CostCalculatorForm  costCalculatorForm;
        DistanceCalculatorForm distanceCalculatorForm;
        ConsumptionCalculatorForm consumptionCalculatorForm;

        private void button_cost_Click(object sender, EventArgs e)
        {
            costCalculatorForm.Show();
        }

        private void button_distance_Click(object sender, EventArgs e)
        {
            distanceCalculatorForm.Show();
        }

        private void button_consumpt_Click(object sender, EventArgs e)
        {
            consumptionCalculatorForm.Show();
        }
    }
}
