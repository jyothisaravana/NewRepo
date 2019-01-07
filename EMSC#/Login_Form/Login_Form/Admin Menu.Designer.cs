namespace Login_Form
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Employee_bt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.AuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Allowance = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Deduction = new System.Windows.Forms.Button();
            this.Pay_slip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deductionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_bt
            // 
            this.Employee_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_bt.Image = ((System.Drawing.Image)(resources.GetObject("Employee_bt.Image")));
            this.Employee_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee_bt.Location = new System.Drawing.Point(488, 180);
            this.Employee_bt.Name = "Employee_bt";
            this.Employee_bt.Size = new System.Drawing.Size(194, 63);
            this.Employee_bt.TabIndex = 5;
            this.Employee_bt.Text = "Employee Manager";
            this.Employee_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Employee_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Employee_bt.UseVisualStyleBackColor = false;
            this.Employee_bt.Click += new System.EventHandler(this.Employee_bt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuditToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(913, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // AuditToolStripMenuItem
            // 
            this.AuditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.AuditToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuditToolStripMenuItem.Name = "AuditToolStripMenuItem";
            this.AuditToolStripMenuItem.ShowShortcutKeys = false;
            this.AuditToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.AuditToolStripMenuItem.Text = "Add User";
            this.AuditToolStripMenuItem.Click += new System.EventHandler(this.AuditToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUserToolStripMenuItem.Image")));
            this.addUserToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // Allowance
            // 
            this.Allowance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allowance.Image = ((System.Drawing.Image)(resources.GetObject("Allowance.Image")));
            this.Allowance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Allowance.Location = new System.Drawing.Point(488, 283);
            this.Allowance.Name = "Allowance";
            this.Allowance.Size = new System.Drawing.Size(194, 63);
            this.Allowance.TabIndex = 8;
            this.Allowance.Text = "Allowance";
            this.Allowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Allowance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Allowance.UseVisualStyleBackColor = false;
            this.Allowance.Click += new System.EventHandler(this.Allowance_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(707, 283);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(194, 63);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update Salary";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(707, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deduction
            // 
            this.Deduction.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deduction.Image = ((System.Drawing.Image)(resources.GetObject("Deduction.Image")));
            this.Deduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deduction.Location = new System.Drawing.Point(488, 365);
            this.Deduction.Name = "Deduction";
            this.Deduction.Size = new System.Drawing.Size(194, 63);
            this.Deduction.TabIndex = 11;
            this.Deduction.Text = "Deduction";
            this.Deduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deduction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Deduction.UseVisualStyleBackColor = false;
            this.Deduction.Click += new System.EventHandler(this.Deduction_Click);
            // 
            // Pay_slip
            // 
            this.Pay_slip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_slip.Image = ((System.Drawing.Image)(resources.GetObject("Pay_slip.Image")));
            this.Pay_slip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pay_slip.Location = new System.Drawing.Point(707, 365);
            this.Pay_slip.Name = "Pay_slip";
            this.Pay_slip.Size = new System.Drawing.Size(194, 63);
            this.Pay_slip.TabIndex = 12;
            this.Pay_slip.Text = "Generate Payslip";
            this.Pay_slip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pay_slip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pay_slip.UseVisualStyleBackColor = false;
            this.Pay_slip.Click += new System.EventHandler(this.Pay_slip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowanceReportToolStripMenuItem,
            this.deductionReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // allowanceReportToolStripMenuItem
            // 
            this.allowanceReportToolStripMenuItem.Name = "allowanceReportToolStripMenuItem";
            this.allowanceReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allowanceReportToolStripMenuItem.Text = "Allowance Report";
            this.allowanceReportToolStripMenuItem.Click += new System.EventHandler(this.allowanceReportToolStripMenuItem_Click);
            // 
            // deductionReportToolStripMenuItem
            // 
            this.deductionReportToolStripMenuItem.Name = "deductionReportToolStripMenuItem";
            this.deductionReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deductionReportToolStripMenuItem.Text = "Deduction Report";
            this.deductionReportToolStripMenuItem.Click += new System.EventHandler(this.deductionReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pay_slip);
            this.Controls.Add(this.Deduction);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Allowance);
            this.Controls.Add(this.Employee_bt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Employee_bt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem AuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.Button Allowance;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Deduction;
        private System.Windows.Forms.Button Pay_slip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deductionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
    }
}

