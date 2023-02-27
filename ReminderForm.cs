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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Range_Calculator_v
{
    public partial class ReminderForm : Form
    {
        private const string ReminderFilePath = "reminder.txt";
        public ReminderForm()
        {
            InitializeComponent();
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            LoadReminder();
        }

        private void LoadReminder()
        {
            if (File.Exists(ReminderFilePath))
            {
                var reminderText = File.ReadAllText(ReminderFilePath);
                reminderLabel.Text = reminderText;
            }
            else
            {
                reminderLabel.Text = "No reminder set";
            }
        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            var reminderText = reminderTextBox.Text.Trim();
            if (string.IsNullOrEmpty(reminderText))
            {
                MessageBox.Show("Please enter a reminder");
                return;
            }

            File.WriteAllText(ReminderFilePath, reminderText);
            LoadReminder();

            MessageBox.Show("Reminder set successfully");
        }

        
private void ClearReminderButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(ReminderFilePath))
            {
                File.Delete(ReminderFilePath);
                reminderLabel.Text = "No reminder set";

                MessageBox.Show("Reminder cleared successfully");
            }

        }
    }
}
