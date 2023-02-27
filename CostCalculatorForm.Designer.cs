namespace Range_Calculator_v
{
    partial class CostCalculatorForm
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
            this.calculateButton2 = new System.Windows.Forms.Button();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.fuelPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fuelNeededLabel = new System.Windows.Forms.Label();
            this.tripCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton2
            // 
            this.calculateButton2.Location = new System.Drawing.Point(40, 233);
            this.calculateButton2.Name = "calculateButton2";
            this.calculateButton2.Size = new System.Drawing.Size(247, 38);
            this.calculateButton2.TabIndex = 0;
            this.calculateButton2.Text = "Calculate";
            this.calculateButton2.UseVisualStyleBackColor = true;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(187, 25);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 1;
            // 
            // fuelConsumptionTextBox
            // 
            this.fuelConsumptionTextBox.Location = new System.Drawing.Point(187, 51);
            this.fuelConsumptionTextBox.Name = "fuelConsumptionTextBox";
            this.fuelConsumptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelConsumptionTextBox.TabIndex = 2;
            // 
            // fuelPriceTextBox
            // 
            this.fuelPriceTextBox.Location = new System.Drawing.Point(187, 77);
            this.fuelPriceTextBox.Name = "fuelPriceTextBox";
            this.fuelPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelPriceTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Distance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fuel consumption :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fuel price :";
            // 
            // fuelNeededLabel
            // 
            this.fuelNeededLabel.AutoSize = true;
            this.fuelNeededLabel.Location = new System.Drawing.Point(184, 297);
            this.fuelNeededLabel.Name = "fuelNeededLabel";
            this.fuelNeededLabel.Size = new System.Drawing.Size(0, 13);
            this.fuelNeededLabel.TabIndex = 7;
            // 
            // tripCostLabel
            // 
            this.tripCostLabel.AutoSize = true;
            this.tripCostLabel.Location = new System.Drawing.Point(184, 319);
            this.tripCostLabel.Name = "tripCostLabel";
            this.tripCostLabel.Size = new System.Drawing.Size(13, 13);
            this.tripCostLabel.TabIndex = 8;
            this.tripCostLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trip cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel needed : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // CostCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tripCostLabel);
            this.Controls.Add(this.fuelNeededLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuelPriceTextBox);
            this.Controls.Add(this.fuelConsumptionTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.calculateButton2);
            this.Name = "CostCalculatorForm";
            this.Text = "CostCalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton2;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox fuelConsumptionTextBox;
        private System.Windows.Forms.TextBox fuelPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fuelNeededLabel;
        private System.Windows.Forms.Label tripCostLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}