namespace Eco_Grocery_Mart
{
    partial class Invoicve
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 8.861538F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(323, 36);
            label1.TabIndex = 0;
            label1.Text = "                                Eco Mart\r\n---------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Invoice No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 99);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 29);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 286);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 6;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 432);
            label7.Name = "label7";
            label7.Size = new Size(175, 21);
            label7.TabIndex = 7;
            label7.Text = "Thankyou Come Again.!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 140);
            label8.Name = "label8";
            label8.Size = new Size(334, 21);
            label8.TabIndex = 8;
            label8.Text = "------------------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 398);
            label9.Name = "label9";
            label9.Size = new Size(334, 21);
            label9.TabIndex = 9;
            label9.Text = "------------------------------------------------------";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Arial Rounded MT Bold", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeight = 31;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(21, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 56;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(325, 203);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Items:";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 135;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price:";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 135;
            // 
            // Invoicve
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 488);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Invoicve";
            Text = "Invoicve";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}