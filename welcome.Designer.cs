namespace Range_Calculator_v
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.btn_fuel = new System.Windows.Forms.Button();
            this.btn_el = new System.Windows.Forms.Button();
            this.ref_btn = new System.Windows.Forms.Button();
            this.Refs_btn = new System.Windows.Forms.Button();
            this.Exp_btn = new System.Windows.Forms.Button();
            this.encome_btn = new System.Windows.Forms.Button();
            this.diagram_btn = new System.Windows.Forms.Button();
            this.ststs_btn = new System.Windows.Forms.Button();
            this.rem_btn = new System.Windows.Forms.Button();
            this.calc_btn = new System.Windows.Forms.Button();
            this.ExpTb_btn = new System.Windows.Forms.Button();
            this.EnTb_btn = new System.Windows.Forms.Button();
            this.lblNextReminder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fuel
            // 
            this.btn_fuel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fuel.Location = new System.Drawing.Point(12, 103);
            this.btn_fuel.Name = "btn_fuel";
            this.btn_fuel.Size = new System.Drawing.Size(87, 73);
            this.btn_fuel.TabIndex = 0;
            this.btn_fuel.Text = "Calculator for trip";
            this.btn_fuel.UseVisualStyleBackColor = false;
            this.btn_fuel.Click += new System.EventHandler(this.btn_fuel_Click);
            // 
            // btn_el
            // 
            this.btn_el.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_el.Enabled = false;
            this.btn_el.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_el.Location = new System.Drawing.Point(808, 24);
            this.btn_el.Name = "btn_el";
            this.btn_el.Size = new System.Drawing.Size(87, 73);
            this.btn_el.TabIndex = 1;
            this.btn_el.Text = "Electric";
            this.btn_el.UseVisualStyleBackColor = false;
            this.btn_el.Click += new System.EventHandler(this.btn_el_Click);
            // 
            // ref_btn
            // 
            this.ref_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ref_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ref_btn.Location = new System.Drawing.Point(12, 24);
            this.ref_btn.Name = "ref_btn";
            this.ref_btn.Size = new System.Drawing.Size(87, 73);
            this.ref_btn.TabIndex = 3;
            this.ref_btn.Text = "Add Refuel";
            this.ref_btn.UseVisualStyleBackColor = false;
            this.ref_btn.Click += new System.EventHandler(this.ref_btn_Click);
            // 
            // Refs_btn
            // 
            this.Refs_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Refs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refs_btn.Location = new System.Drawing.Point(105, 24);
            this.Refs_btn.Name = "Refs_btn";
            this.Refs_btn.Size = new System.Drawing.Size(87, 73);
            this.Refs_btn.TabIndex = 4;
            this.Refs_btn.Text = "Refuelings Tabel";
            this.Refs_btn.UseVisualStyleBackColor = false;
            this.Refs_btn.Click += new System.EventHandler(this.Refs_btn_Click);
            // 
            // Exp_btn
            // 
            this.Exp_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exp_btn.Location = new System.Drawing.Point(198, 24);
            this.Exp_btn.Name = "Exp_btn";
            this.Exp_btn.Size = new System.Drawing.Size(87, 73);
            this.Exp_btn.TabIndex = 5;
            this.Exp_btn.Text = "Add Expenses";
            this.Exp_btn.UseVisualStyleBackColor = false;
            this.Exp_btn.Click += new System.EventHandler(this.Exp_btn_Click);
            // 
            // encome_btn
            // 
            this.encome_btn.Enabled = false;
            this.encome_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encome_btn.Location = new System.Drawing.Point(436, 24);
            this.encome_btn.Name = "encome_btn";
            this.encome_btn.Size = new System.Drawing.Size(87, 73);
            this.encome_btn.TabIndex = 6;
            this.encome_btn.Text = "Encome and savings";
            this.encome_btn.UseVisualStyleBackColor = true;
            this.encome_btn.Click += new System.EventHandler(this.encome_btn_Click);
            // 
            // diagram_btn
            // 
            this.diagram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagram_btn.Location = new System.Drawing.Point(198, 103);
            this.diagram_btn.Name = "diagram_btn";
            this.diagram_btn.Size = new System.Drawing.Size(87, 73);
            this.diagram_btn.TabIndex = 7;
            this.diagram_btn.Text = "Statistics";
            this.diagram_btn.UseVisualStyleBackColor = true;
            this.diagram_btn.Click += new System.EventHandler(this.diagram_btn_Click);
            // 
            // ststs_btn
            // 
            this.ststs_btn.Enabled = false;
            this.ststs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ststs_btn.Location = new System.Drawing.Point(622, 24);
            this.ststs_btn.Name = "ststs_btn";
            this.ststs_btn.Size = new System.Drawing.Size(87, 73);
            this.ststs_btn.TabIndex = 8;
            this.ststs_btn.Text = "wasStatistics but now is diagram))";
            this.ststs_btn.UseVisualStyleBackColor = true;
            this.ststs_btn.Click += new System.EventHandler(this.ststs_btn_Click);
            // 
            // rem_btn
            // 
            this.rem_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rem_btn.Location = new System.Drawing.Point(105, 103);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(87, 73);
            this.rem_btn.TabIndex = 9;
            this.rem_btn.Text = "Reminder ";
            this.rem_btn.UseVisualStyleBackColor = false;
            this.rem_btn.Click += new System.EventHandler(this.rem_btn_Click);
            // 
            // calc_btn
            // 
            this.calc_btn.Enabled = false;
            this.calc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc_btn.Location = new System.Drawing.Point(715, 24);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(87, 73);
            this.calc_btn.TabIndex = 10;
            this.calc_btn.Text = "Calculator";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // ExpTb_btn
            // 
            this.ExpTb_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExpTb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpTb_btn.Location = new System.Drawing.Point(291, 24);
            this.ExpTb_btn.Name = "ExpTb_btn";
            this.ExpTb_btn.Size = new System.Drawing.Size(87, 73);
            this.ExpTb_btn.TabIndex = 13;
            this.ExpTb_btn.Text = "Expenses Tabel";
            this.ExpTb_btn.UseVisualStyleBackColor = false;
            this.ExpTb_btn.Click += new System.EventHandler(this.ExpTb_btn_Click);
            // 
            // EnTb_btn
            // 
            this.EnTb_btn.Enabled = false;
            this.EnTb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnTb_btn.Location = new System.Drawing.Point(529, 24);
            this.EnTb_btn.Name = "EnTb_btn";
            this.EnTb_btn.Size = new System.Drawing.Size(87, 73);
            this.EnTb_btn.TabIndex = 14;
            this.EnTb_btn.Text = "Encome tabel";
            this.EnTb_btn.UseVisualStyleBackColor = true;
            this.EnTb_btn.Click += new System.EventHandler(this.EnTb_btn_Click);
            // 
            // lblNextReminder
            // 
            this.lblNextReminder.AutoSize = true;
            this.lblNextReminder.Enabled = false;
            this.lblNextReminder.Location = new System.Drawing.Point(433, 103);
            this.lblNextReminder.Name = "lblNextReminder";
            this.lblNextReminder.Size = new System.Drawing.Size(104, 13);
            this.lblNextReminder.TabIndex = 11;
            this.lblNextReminder.Text = "Next reminder: None";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-92, -220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 592);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 367);
            this.Controls.Add(this.EnTb_btn);
            this.Controls.Add(this.ExpTb_btn);
            this.Controls.Add(this.lblNextReminder);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.rem_btn);
            this.Controls.Add(this.ststs_btn);
            this.Controls.Add(this.diagram_btn);
            this.Controls.Add(this.encome_btn);
            this.Controls.Add(this.Exp_btn);
            this.Controls.Add(this.Refs_btn);
            this.Controls.Add(this.ref_btn);
            this.Controls.Add(this.btn_el);
            this.Controls.Add(this.btn_fuel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "welcome";
            this.Text = "FuelCounter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fuel;
        private System.Windows.Forms.Button btn_el;
        private System.Windows.Forms.Button ref_btn;
        private System.Windows.Forms.Button Refs_btn;
        private System.Windows.Forms.Button Exp_btn;
        private System.Windows.Forms.Button encome_btn;
        private System.Windows.Forms.Button diagram_btn;
        private System.Windows.Forms.Button ststs_btn;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button ExpTb_btn;
        private System.Windows.Forms.Button EnTb_btn;
        private System.Windows.Forms.Label lblNextReminder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}