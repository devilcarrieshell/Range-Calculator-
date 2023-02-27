namespace Range_Calculator_v
{
    partial class CalculatorForm
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
            this.button_cost = new System.Windows.Forms.Button();
            this.button_distance = new System.Windows.Forms.Button();
            this.button_consumpt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cost
            // 
            this.button_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cost.Location = new System.Drawing.Point(12, 65);
            this.button_cost.Name = "button_cost";
            this.button_cost.Size = new System.Drawing.Size(87, 73);
            this.button_cost.TabIndex = 0;
            this.button_cost.Text = "Cost of the trip";
            this.button_cost.UseVisualStyleBackColor = true;
            this.button_cost.Click += new System.EventHandler(this.button_cost_Click);
            // 
            // button_distance
            // 
            this.button_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_distance.Location = new System.Drawing.Point(105, 65);
            this.button_distance.Name = "button_distance";
            this.button_distance.Size = new System.Drawing.Size(87, 73);
            this.button_distance.TabIndex = 1;
            this.button_distance.Text = "Travel distance";
            this.button_distance.UseVisualStyleBackColor = true;
            this.button_distance.Click += new System.EventHandler(this.button_distance_Click);
            // 
            // button_consumpt
            // 
            this.button_consumpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_consumpt.Location = new System.Drawing.Point(198, 65);
            this.button_consumpt.Name = "button_consumpt";
            this.button_consumpt.Size = new System.Drawing.Size(87, 73);
            this.button_consumpt.TabIndex = 2;
            this.button_consumpt.Text = "Fuel consumption";
            this.button_consumpt.UseVisualStyleBackColor = true;
            this.button_consumpt.Click += new System.EventHandler(this.button_consumpt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "What do you want to calculate?";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_consumpt);
            this.Controls.Add(this.button_distance);
            this.Controls.Add(this.button_cost);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cost;
        private System.Windows.Forms.Button button_distance;
        private System.Windows.Forms.Button button_consumpt;
        private System.Windows.Forms.Label label1;
    }
}