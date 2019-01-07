namespace Login_Form
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Pay_slip = new System.Windows.Forms.Button();
            this.Deduction = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Allowance = new System.Windows.Forms.Button();
            this.Employee_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pay_slip
            // 
            this.Pay_slip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_slip.Image = ((System.Drawing.Image)(resources.GetObject("Pay_slip.Image")));
            this.Pay_slip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pay_slip.Location = new System.Drawing.Point(586, 370);
            this.Pay_slip.Name = "Pay_slip";
            this.Pay_slip.Size = new System.Drawing.Size(194, 63);
            this.Pay_slip.TabIndex = 18;
            this.Pay_slip.Text = "Generate Payslip";
            this.Pay_slip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pay_slip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pay_slip.UseVisualStyleBackColor = false;
            this.Pay_slip.Click += new System.EventHandler(this.Pay_slip_Click);
            // 
            // Deduction
            // 
            this.Deduction.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deduction.Image = ((System.Drawing.Image)(resources.GetObject("Deduction.Image")));
            this.Deduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deduction.Location = new System.Drawing.Point(367, 370);
            this.Deduction.Name = "Deduction";
            this.Deduction.Size = new System.Drawing.Size(194, 63);
            this.Deduction.TabIndex = 17;
            this.Deduction.Text = "Deduction";
            this.Deduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deduction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Deduction.UseVisualStyleBackColor = false;
            this.Deduction.Click += new System.EventHandler(this.Deduction_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(586, 185);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(194, 63);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(586, 288);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(194, 63);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update Salary";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Allowance
            // 
            this.Allowance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allowance.Image = ((System.Drawing.Image)(resources.GetObject("Allowance.Image")));
            this.Allowance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Allowance.Location = new System.Drawing.Point(367, 288);
            this.Allowance.Name = "Allowance";
            this.Allowance.Size = new System.Drawing.Size(194, 63);
            this.Allowance.TabIndex = 14;
            this.Allowance.Text = "Allowance";
            this.Allowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Allowance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Allowance.UseVisualStyleBackColor = false;
            this.Allowance.Click += new System.EventHandler(this.Allowance_Click);
            // 
            // Employee_bt
            // 
            this.Employee_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_bt.Image = ((System.Drawing.Image)(resources.GetObject("Employee_bt.Image")));
            this.Employee_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee_bt.Location = new System.Drawing.Point(367, 185);
            this.Employee_bt.Name = "Employee_bt";
            this.Employee_bt.Size = new System.Drawing.Size(194, 63);
            this.Employee_bt.TabIndex = 13;
            this.Employee_bt.Text = "Employee Manager";
            this.Employee_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Employee_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Employee_bt.UseVisualStyleBackColor = false;
            this.Employee_bt.Click += new System.EventHandler(this.Employee_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(716, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(716, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pay_slip);
            this.Controls.Add(this.Deduction);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Allowance);
            this.Controls.Add(this.Employee_bt);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pay_slip;
        private System.Windows.Forms.Button Deduction;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Allowance;
        private System.Windows.Forms.Button Employee_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}