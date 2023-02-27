using System;

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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkPremium
            // 
            this.chkPremium.AutoSize = true;
            this.chkPremium.BackColor = System.Drawing.SystemColors.Window;
            this.chkPremium.Location = new System.Drawing.Point(278, 173);
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
            this.chkDisel.Location = new System.Drawing.Point(278, 150);
            this.chkDisel.Name = "chkDisel";
            this.chkDisel.Size = new System.Drawing.Size(57, 17);
            this.chkDisel.TabIndex = 28;
            this.chkDisel.Text = "Simple";
            this.chkDisel.UseVisualStyleBackColor = false;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(243, 258);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(136, 20);
            this.txtEngineSize.TabIndex = 27;
            // 
            // txtVehicleWeight
            // 
            this.txtVehicleWeight.Location = new System.Drawing.Point(243, 226);
            this.txtVehicleWeight.Name = "txtVehicleWeight";
            this.txtVehicleWeight.Size = new System.Drawing.Size(136, 20);
            this.txtVehicleWeight.TabIndex = 26;
            // 
            // txtTripDistance
            // 
            this.txtTripDistance.Location = new System.Drawing.Point(243, 114);
            this.txtTripDistance.Name = "txtTripDistance";
            this.txtTripDistance.Size = new System.Drawing.Size(73, 20);
            this.txtTripDistance.TabIndex = 25;
            // 
            // txtFuelConsumption
            // 
            this.txtFuelConsumption.Location = new System.Drawing.Point(243, 86);
            this.txtFuelConsumption.Name = "txtFuelConsumption";
            this.txtFuelConsumption.Size = new System.Drawing.Size(73, 20);
            this.txtFuelConsumption.TabIndex = 24;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(49, 315);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(330, 40);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(200, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Please enter the value using \",\" sign";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(35, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter engine size (L):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter vehicle weight (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter trip distance (km):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter fuel consumption (L/100km):";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(0, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(70, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideButton.Location = new System.Drawing.Point(292, 361);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(87, 40);
            this.hideButton.TabIndex = 33;
            this.hideButton.Text = "Back";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 479);
            this.ControlBox = false;
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.chkPremium);
            this.Controls.Add(this.chkDisel);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtVehicleWeight);
            this.Controls.Add(this.txtTripDistance);
            this.Controls.Add(this.txtFuelConsumption);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button hideButton;
    }
}

