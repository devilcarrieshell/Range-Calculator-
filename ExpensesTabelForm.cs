using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Range_Calculator_v.ExpensesForm;

namespace Range_Calculator_v
{
    public partial class ExpensesTabelForm : Form
    {
        // In case of describe the class in separate .cs file
        //private readonly List<Expense> expenses;
        //public ExpensesTabelForm(List<Expense> expenses)
        //
        //    InitializeComponent();
        //    this.expenses = expenses;
        //}

        public ExpensesTabelForm()
        {
            InitializeComponent();
            LoadExpensesTable();
        }
        
            
        

        private void ExpensesTableForm_Load(object sender, EventArgs e)
        {
            LoadExpensesTable();
        }

        private void LoadExpensesTable()
        {
            //Add cols to the table
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("Date", typeof(DateTime));
            //dataTable.Columns.Add("Odometer", typeof(int));
            //dataTable.Columns.Add("Type", typeof(string));
            //dataTable.Columns.Add("Comment", typeof(string));
            //dataTable.Columns.Add("Amount", typeof(double));

            //Load data from the CSV file


            // In case of describe the class in separate .cs file
            //
            //foreach (var expense in expenses)
            //{
            //    dataTable.Rows.Add(expense.DateTime, expense.Odometer, expense.Type, expense.Comment, expense.Amount);
            //}
            //
            //expensesDataGridView.DataSource = dataTable;

            //Add cols
            
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Odometer", "Odometer range");
            dataGridView1.Columns.Add("Type", "Expence type");
            dataGridView1.Columns.Add("Comment", "Comments");
            dataGridView1.Columns.Add("Amount", "Amount");

            //Load data from the CSV file
            string fileName = "expenses.csv";
            string[] lines = File.ReadAllLines(fileName);

            //Add each record to the DataGridView
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                dataGridView1.Rows.Add(fields);
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
