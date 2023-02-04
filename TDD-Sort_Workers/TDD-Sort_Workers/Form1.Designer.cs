
namespace TDD_Sort_Workers
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.Telephone_Box = new System.Windows.Forms.TextBox();
            this.Address_Box = new System.Windows.Forms.TextBox();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Salary_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addWorker_button = new System.Windows.Forms.Button();
            this.randomWorkers_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.calcTax_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.taxValue = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.close_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1221, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ת\"ז";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(1067, 66);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(4);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(123, 22);
            this.ID_Box.TabIndex = 1;
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(1067, 98);
            this.FirstName_Box.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(123, 22);
            this.FirstName_Box.TabIndex = 2;
            // 
            // Telephone_Box
            // 
            this.Telephone_Box.Location = new System.Drawing.Point(1067, 130);
            this.Telephone_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Telephone_Box.Name = "Telephone_Box";
            this.Telephone_Box.Size = new System.Drawing.Size(123, 22);
            this.Telephone_Box.TabIndex = 3;
            // 
            // Address_Box
            // 
            this.Address_Box.Location = new System.Drawing.Point(787, 66);
            this.Address_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(123, 22);
            this.Address_Box.TabIndex = 4;
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(787, 98);
            this.LastName_Box.Margin = new System.Windows.Forms.Padding(4);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(123, 22);
            this.LastName_Box.TabIndex = 5;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(787, 130);
            this.Email_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(123, 22);
            this.Email_Box.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1221, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1221, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "טלפון";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(948, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(948, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "שם משפחה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(948, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "אימייל";
            // 
            // Salary_Box
            // 
            this.Salary_Box.Location = new System.Drawing.Point(1067, 162);
            this.Salary_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Salary_Box.Name = "Salary_Box";
            this.Salary_Box.Size = new System.Drawing.Size(123, 22);
            this.Salary_Box.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1221, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "משכורת";
            // 
            // addWorker_button
            // 
            this.addWorker_button.Location = new System.Drawing.Point(787, 347);
            this.addWorker_button.Margin = new System.Windows.Forms.Padding(4);
            this.addWorker_button.Name = "addWorker_button";
            this.addWorker_button.Size = new System.Drawing.Size(485, 60);
            this.addWorker_button.TabIndex = 14;
            this.addWorker_button.Text = "הוספת עובד";
            this.addWorker_button.UseVisualStyleBackColor = true;
            this.addWorker_button.Click += new System.EventHandler(this.addWorker_button_Click);
            // 
            // randomWorkers_button
            // 
            this.randomWorkers_button.Location = new System.Drawing.Point(787, 447);
            this.randomWorkers_button.Margin = new System.Windows.Forms.Padding(4);
            this.randomWorkers_button.Name = "randomWorkers_button";
            this.randomWorkers_button.Size = new System.Drawing.Size(485, 55);
            this.randomWorkers_button.TabIndex = 15;
            this.randomWorkers_button.Text = "הוספת 10,000 עובדים";
            this.randomWorkers_button.UseVisualStyleBackColor = true;
            this.randomWorkers_button.Click += new System.EventHandler(this.randomWorkers_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(787, 535);
            this.sort_button.Margin = new System.Windows.Forms.Padding(4);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(485, 54);
            this.sort_button.TabIndex = 16;
            this.sort_button.Text = "מיון לפי משכורת";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(787, 623);
            this.show_button.Margin = new System.Windows.Forms.Padding(4);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(485, 55);
            this.show_button.TabIndex = 17;
            this.show_button.Text = "הצג רשימת עובדים";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "רשימת עובדים";
            // 
            // calcTax_button
            // 
            this.calcTax_button.Location = new System.Drawing.Point(357, 772);
            this.calcTax_button.Margin = new System.Windows.Forms.Padding(4);
            this.calcTax_button.Name = "calcTax_button";
            this.calcTax_button.Size = new System.Drawing.Size(245, 57);
            this.calcTax_button.TabIndex = 20;
            this.calcTax_button.Text = "חישוב מס";
            this.toolTip1.SetToolTip(this.calcTax_button, "אנא לחץ על משכורת מעמודת המשכורת של העובד הרצוי לחישוב המס עליו לשלם");
            this.calcTax_button.UseVisualStyleBackColor = true;
            this.calcTax_button.Click += new System.EventHandler(this.calcTax_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 793);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = ":מס הכנסה חודשי";
            // 
            // taxValue
            // 
            this.taxValue.AutoSize = true;
            this.taxValue.Location = new System.Drawing.Point(103, 793);
            this.taxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxValue.Name = "taxValue";
            this.taxValue.Size = new System.Drawing.Size(53, 17);
            this.taxValue.TabIndex = 25;
            this.taxValue.Text = "XXXXX";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 139);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 613);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "משכורת";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ת\"ז";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(1204, 772);
            this.close_button.Margin = new System.Windows.Forms.Padding(4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(108, 57);
            this.close_button.TabIndex = 28;
            this.close_button.Text = "יציאה";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(1067, 215);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(108, 46);
            this.refresh_button.TabIndex = 29;
            this.refresh_button.Text = "איפוס";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1332, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 24);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TDD_Sort_Workers.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(76, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1359, 869);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.taxValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calcTax_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.randomWorkers_button);
            this.Controls.Add(this.addWorker_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Salary_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.Telephone_Box);
            this.Controls.Add(this.FirstName_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "פרטי עובדים במפעל";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.TextBox Telephone_Box;
        private System.Windows.Forms.TextBox Address_Box;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Salary_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addWorker_button;
        private System.Windows.Forms.Button randomWorkers_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calcTax_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label taxValue;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label btnExit;
    }
}

