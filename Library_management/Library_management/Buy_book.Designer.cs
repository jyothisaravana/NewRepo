namespace Library_management
{
    partial class Buy_book
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
            this.Scombobox = new System.Windows.Forms.ComboBox();
            this.HcomboBox = new System.Windows.Forms.ComboBox();
            this.LcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scombobox
            // 
            this.Scombobox.FormattingEnabled = true;
            this.Scombobox.Items.AddRange(new object[] {
            "The Breif History of Time-Rs120",
            "Evolution-Rs400",
            "Galaxy- the mystery of the Universe-Rs700",
            "Anatomy of Human Body-Rs-800"});
            this.Scombobox.Location = new System.Drawing.Point(59, 162);
            this.Scombobox.Name = "Scombobox";
            this.Scombobox.Size = new System.Drawing.Size(121, 21);
            this.Scombobox.TabIndex = 0;
            this.Scombobox.Text = "Science";
            this.Scombobox.SelectedIndexChanged += new System.EventHandler(this.Scombobox_SelectedIndexChanged);
            // 
            // HcomboBox
            // 
            this.HcomboBox.FormattingEnabled = true;
            this.HcomboBox.Items.AddRange(new object[] {
            "World war I-Rs.400",
            "World War II-Rs.300",
            "Indian Hitory-Rs.550",
            "The great freedom fighters of india-Rs.440",
            "British Rule-Rs.550"});
            this.HcomboBox.Location = new System.Drawing.Point(350, 162);
            this.HcomboBox.Name = "HcomboBox";
            this.HcomboBox.Size = new System.Drawing.Size(121, 21);
            this.HcomboBox.TabIndex = 1;
            this.HcomboBox.Text = "History";
            this.HcomboBox.SelectedIndexChanged += new System.EventHandler(this.HcomboBox_SelectedIndexChanged);
            // 
            // LcomboBox
            // 
            this.LcomboBox.FormattingEnabled = true;
            this.LcomboBox.Items.AddRange(new object[] {
            "Pride and Prejudge-Rs.400",
            "1984-Rs.330",
            "The great Gatsby-Rs.840",
            "Heart of Darkness-Rs.650",
            "Brave new-Rs.780"});
            this.LcomboBox.Location = new System.Drawing.Point(634, 162);
            this.LcomboBox.Name = "LcomboBox";
            this.LcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LcomboBox.TabIndex = 2;
            this.LcomboBox.Text = "Literature";
            this.LcomboBox.SelectedIndexChanged += new System.EventHandler(this.LcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books available in library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Your Book";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(379, 274);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 39);
            this.Done.TabIndex = 5;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Buy_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 541);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LcomboBox);
            this.Controls.Add(this.HcomboBox);
            this.Controls.Add(this.Scombobox);
            this.Name = "Buy_book";
            this.Text = "Buy_book";
            this.Load += new System.EventHandler(this.Buy_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Scombobox;
        private System.Windows.Forms.ComboBox HcomboBox;
        private System.Windows.Forms.ComboBox LcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Done;
    }
}