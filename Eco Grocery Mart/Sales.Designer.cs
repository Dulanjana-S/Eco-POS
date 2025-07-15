namespace Eco_Grocery_Mart
{
    partial class Sales
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 21);
            label1.Name = "label1";
            label1.Size = new Size(248, 33);
            label1.TabIndex = 0;
            label1.Text = "Eco Mart - Sales ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.1846151F, FontStyle.Bold);
            label2.Location = new Point(42, 77);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 1;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.1846151F, FontStyle.Bold);
            label3.Location = new Point(42, 135);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.1846151F, FontStyle.Bold);
            label4.Location = new Point(427, 134);
            label4.Name = "label4";
            label4.Size = new Size(54, 30);
            label4.TabIndex = 3;
            label4.Text = "Qty:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(590, 29);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(153, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(553, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 29);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(470, 185);
            button1.Name = "button1";
            button1.Size = new Size(273, 47);
            button1.TabIndex = 7;
            button1.Text = "+ Add to Cart";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.1846151F, FontStyle.Bold);
            label5.Location = new Point(415, 483);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 21;
            label5.Text = "Grand Total:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(553, 484);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 29);
            textBox3.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Arial Rounded MT Bold", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(611, 532);
            button2.Name = "button2";
            button2.Size = new Size(132, 46);
            button2.TabIndex = 23;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(71, 517);
            button3.Name = "button3";
            button3.Size = new Size(132, 46);
            button3.TabIndex = 24;
            button3.Text = "Clear Cart";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 8.861538F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(71, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(672, 195);
            dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 135;
            // 
            // Column2
            // 
            Column2.HeaderText = "product";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 135;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 135;
            // 
            // Column4
            // 
            Column4.HeaderText = "Qty";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            Column4.Width = 135;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            Column5.Width = 135;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 29);
            dateTimePicker1.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.1846151F, FontStyle.Bold);
            label6.Location = new Point(42, 192);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 27;
            label6.Text = "Sale Date";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 595);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}