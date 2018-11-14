namespace Library_management
{
    partial class Library_page
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
            this.label2 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.RadioButton();
            this.Rent = new System.Windows.Forms.RadioButton();
            this.Done_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is your choice?";
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.Location = new System.Drawing.Point(239, 187);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(43, 17);
            this.Buy.TabIndex = 15;
            this.Buy.TabStop = true;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Location = new System.Drawing.Point(459, 187);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(48, 17);
            this.Rent.TabIndex = 16;
            this.Rent.TabStop = true;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            // 
            // Done_bt
            // 
            this.Done_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Done_bt.Location = new System.Drawing.Point(337, 262);
            this.Done_bt.Name = "Done_bt";
            this.Done_bt.Size = new System.Drawing.Size(75, 41);
            this.Done_bt.TabIndex = 17;
            this.Done_bt.Text = "Done";
            this.Done_bt.UseVisualStyleBackColor = true;
            this.Done_bt.Click += new System.EventHandler(this.Done_bt_Click);
            // 
            // Library_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Done_bt);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Library_page";
            this.Text = "Library_page";
            this.Load += new System.EventHandler(this.Library_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Buy;
        private System.Windows.Forms.RadioButton Rent;
        private System.Windows.Forms.Button Done_bt;
    }
}