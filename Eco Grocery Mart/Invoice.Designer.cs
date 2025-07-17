namespace Eco_Grocery_Mart
{
    partial class Invoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 39);
            label1.Name = "label1";
            label1.Size = new Size(481, 26);
            label1.TabIndex = 0;
            label1.Text = "-------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.0769234F, FontStyle.Bold);
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 1;
            label2.Text = "Invoice No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.0769234F, FontStyle.Bold);
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.0769234F, FontStyle.Bold);
            label6.Location = new Point(21, 161);
            label6.Name = "label6";
            label6.Size = new Size(57, 24);
            label6.TabIndex = 6;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12.1846151F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(112, 499);
            label7.Name = "label7";
            label7.Size = new Size(259, 27);
            label7.TabIndex = 7;
            label7.Text = "Thankyou Come Again.!";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 185);
            label8.Name = "label8";
            label8.Size = new Size(474, 26);
            label8.TabIndex = 8;
            label8.Text = "------------------------------------------------------------------";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 31;
            dataGridView1.GridColor = SystemColors.ControlText;
            dataGridView1.Location = new Point(15, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 56;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(467, 233);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 65);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 473);
            label4.Name = "label4";
            label4.Size = new Size(467, 26);
            label4.TabIndex = 12;
            label4.Text = "-----------------------------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 526);
            label9.Name = "label9";
            label9.Size = new Size(467, 26);
            label9.TabIndex = 13;
            label9.Text = "-----------------------------------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 13.8461533F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(180, 9);
            label10.Name = "label10";
            label10.Size = new Size(145, 31);
            label10.TabIndex = 14;
            label10.Text = "~Eco Mart~";
            label10.Click += label10_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 561);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Invoice";
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label10;
    }
}