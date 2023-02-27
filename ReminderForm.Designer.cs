namespace Range_Calculator_v
{
    partial class ReminderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reminderTextBox = new System.Windows.Forms.TextBox();
            this.btnSetReminder = new System.Windows.Forms.Button();
            this.ClearReminderButton = new System.Windows.Forms.Button();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reminder";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(70, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // reminderTextBox
            // 
            this.reminderTextBox.Location = new System.Drawing.Point(70, 66);
            this.reminderTextBox.Multiline = true;
            this.reminderTextBox.Name = "reminderTextBox";
            this.reminderTextBox.Size = new System.Drawing.Size(200, 106);
            this.reminderTextBox.TabIndex = 2;
            // 
            // btnSetReminder
            // 
            this.btnSetReminder.Location = new System.Drawing.Point(158, 265);
            this.btnSetReminder.Name = "btnSetReminder";
            this.btnSetReminder.Size = new System.Drawing.Size(112, 40);
            this.btnSetReminder.TabIndex = 3;
            this.btnSetReminder.Text = "Set Reminder";
            this.btnSetReminder.UseVisualStyleBackColor = true;
            this.btnSetReminder.Click += new System.EventHandler(this.btnSetReminder_Click);
            // 
            // ClearReminderButton
            // 
            this.ClearReminderButton.Location = new System.Drawing.Point(40, 265);
            this.ClearReminderButton.Name = "ClearReminderButton";
            this.ClearReminderButton.Size = new System.Drawing.Size(112, 40);
            this.ClearReminderButton.TabIndex = 4;
            this.ClearReminderButton.Text = "Clear Reminder";
            this.ClearReminderButton.UseVisualStyleBackColor = true;
            this.ClearReminderButton.Click += new System.EventHandler(this.ClearReminderButton_Click);
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Location = new System.Drawing.Point(37, 213);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(35, 13);
            this.reminderLabel.TabIndex = 5;
            this.reminderLabel.Text = "label2";
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reminderLabel);
            this.Controls.Add(this.ClearReminderButton);
            this.Controls.Add(this.btnSetReminder);
            this.Controls.Add(this.reminderTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "ReminderForm";
            this.Text = "ReminderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox reminderTextBox;
        private System.Windows.Forms.Button btnSetReminder;
        private System.Windows.Forms.Button ClearReminderButton;
        private System.Windows.Forms.Label reminderLabel;
    }
}