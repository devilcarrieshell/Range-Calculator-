namespace Range_Calculator_v
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора. 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkPremium = new System.Windows.Forms.CheckBox();
            this.chkDisel = new System.Windows.Forms.CheckBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtVehicleWeight = new System.Windows.Forms.TextBox();
            this.txtTripDistance = new System.Windows.Forms.TextBox();
            this.txtFuelConsumption = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPremium
            // 
            this.chkPremium.AutoSize = true;
            this.chkPremium.BackColor = System.Drawing.SystemColors.Window;
            this.chkPremium.Location = new System.Drawing.Point(271, 200);
            this.chkPremium.Name = "chkPremium";
            this.chkPremium.Size = new System.Drawing.Size(66, 17);
            this.chkPremium.TabIndex = 29;
            this.chkPremium.Text = "Premium";
            this.chkPremium.UseVisualStyleBackColor = false;
            // 
            // chkDisel
            // 
            this.chkDisel.AutoSize = true;
            this.chkDisel.BackColor = System.Drawing.SystemColors.Window;
            this.chkDisel.Location = new System.Drawing.Point(271, 177);
            this.chkDisel.Name = "chkDisel";
            this.chkDisel.Size = new System.Drawing.Size(57, 17);
            this.chkDisel.TabIndex = 28;
            this.chkDisel.Text = "Simple";
            this.chkDisel.UseVisualStyleBackColor = false;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(271, 231);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(136, 20);
            this.txtEngineSize.TabIndex = 27;
            // 
            // txtVehicleWeight
            // 
            this.txtVehicleWeight.Location = new System.Drawing.Point(271, 150);
            this.txtVehicleWeight.Name = "txtVehicleWeight";
            this.txtVehicleWeight.Size = new System.Drawing.Size(136, 20);
            this.txtVehicleWeight.TabIndex = 26;
            // 
            // txtTripDistance
            // 
            this.txtTripDistance.Location = new System.Drawing.Point(271, 116);
            this.txtTripDistance.Name = "txtTripDistance";
            this.txtTripDistance.Size = new System.Drawing.Size(136, 20);
            this.txtTripDistance.TabIndex = 25;
            // 
            // txtFuelConsumption
            // 
            this.txtFuelConsumption.Location = new System.Drawing.Point(271, 46);
            this.txtFuelConsumption.Name = "txtFuelConsumption";
            this.txtFuelConsumption.Size = new System.Drawing.Size(136, 20);
            this.txtFuelConsumption.TabIndex = 24;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(77, 310);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(330, 62);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(228, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Please enter the value using \",\" sign";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(228, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Please enter the value using \",\" sign";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(63, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter engine size (L):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(63, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter fuel type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(63, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter vehicle weight (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(63, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter trip distance (km):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter fuel consumption (L/100km):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 592);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 588);
            this.Controls.Add(this.chkPremium);
            this.Controls.Add(this.chkDisel);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtVehicleWeight);
            this.Controls.Add(this.txtTripDistance);
            this.Controls.Add(this.txtFuelConsumption);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(512, 627);
            this.MinimumSize = new System.Drawing.Size(512, 627);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Range calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.CheckBox chkDisel;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtVehicleWeight;
        private System.Windows.Forms.TextBox txtTripDistance;
        private System.Windows.Forms.TextBox txtFuelConsumption;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

