namespace Range_Calculator_v
{
    partial class DiagramForm
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
            this.gasStationsCountLabel = new System.Windows.Forms.Label();
            this.expensesCountLabel = new System.Windows.Forms.Label();
            this.litersFilledLabel = new System.Windows.Forms.Label();
            this.kmDrivenLabel = new System.Windows.Forms.Label();
            this.gasStationsAmountLabel = new System.Windows.Forms.Label();
            this.otherExpensesAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gasStationsCountLabel
            // 
            this.gasStationsCountLabel.AutoSize = true;
            this.gasStationsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasStationsCountLabel.Location = new System.Drawing.Point(35, 40);
            this.gasStationsCountLabel.Name = "gasStationsCountLabel";
            this.gasStationsCountLabel.Size = new System.Drawing.Size(51, 20);
            this.gasStationsCountLabel.TabIndex = 0;
            this.gasStationsCountLabel.Text = "label1";
            // 
            // expensesCountLabel
            // 
            this.expensesCountLabel.AutoSize = true;
            this.expensesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expensesCountLabel.Location = new System.Drawing.Point(35, 70);
            this.expensesCountLabel.Name = "expensesCountLabel";
            this.expensesCountLabel.Size = new System.Drawing.Size(51, 20);
            this.expensesCountLabel.TabIndex = 1;
            this.expensesCountLabel.Text = "label1";
            // 
            // litersFilledLabel
            // 
            this.litersFilledLabel.AutoSize = true;
            this.litersFilledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.litersFilledLabel.Location = new System.Drawing.Point(35, 130);
            this.litersFilledLabel.Name = "litersFilledLabel";
            this.litersFilledLabel.Size = new System.Drawing.Size(51, 20);
            this.litersFilledLabel.TabIndex = 2;
            this.litersFilledLabel.Text = "label1";
            // 
            // kmDrivenLabel
            // 
            this.kmDrivenLabel.AutoSize = true;
            this.kmDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kmDrivenLabel.Location = new System.Drawing.Point(35, 100);
            this.kmDrivenLabel.Name = "kmDrivenLabel";
            this.kmDrivenLabel.Size = new System.Drawing.Size(51, 20);
            this.kmDrivenLabel.TabIndex = 3;
            this.kmDrivenLabel.Text = "label1";
            // 
            // gasStationsAmountLabel
            // 
            this.gasStationsAmountLabel.AutoSize = true;
            this.gasStationsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasStationsAmountLabel.Location = new System.Drawing.Point(35, 160);
            this.gasStationsAmountLabel.Name = "gasStationsAmountLabel";
            this.gasStationsAmountLabel.Size = new System.Drawing.Size(51, 20);
            this.gasStationsAmountLabel.TabIndex = 4;
            this.gasStationsAmountLabel.Text = "label1";
            // 
            // otherExpensesAmountLabel
            // 
            this.otherExpensesAmountLabel.AutoSize = true;
            this.otherExpensesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherExpensesAmountLabel.Location = new System.Drawing.Point(35, 190);
            this.otherExpensesAmountLabel.Name = "otherExpensesAmountLabel";
            this.otherExpensesAmountLabel.Size = new System.Drawing.Size(51, 20);
            this.otherExpensesAmountLabel.TabIndex = 5;
            this.otherExpensesAmountLabel.Text = "label1";
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otherExpensesAmountLabel);
            this.Controls.Add(this.gasStationsAmountLabel);
            this.Controls.Add(this.kmDrivenLabel);
            this.Controls.Add(this.litersFilledLabel);
            this.Controls.Add(this.expensesCountLabel);
            this.Controls.Add(this.gasStationsCountLabel);
            this.Name = "DiagramForm";
            this.Text = "DiagramForm";
            this.Shown += new System.EventHandler(this.DiagramForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label gasStationsCountLabel;
        public System.Windows.Forms.Label expensesCountLabel;
        public System.Windows.Forms.Label litersFilledLabel;
        public System.Windows.Forms.Label kmDrivenLabel;
        public System.Windows.Forms.Label gasStationsAmountLabel;
        public System.Windows.Forms.Label otherExpensesAmountLabel;
    }
}