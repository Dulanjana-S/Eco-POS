namespace Eco_Grocery_Mart
{
    partial class Sales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.0615387F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(372, 23);
            label1.Name = "label1";
            label1.Size = new Size(177, 33);
            label1.TabIndex = 0;
            label1.Text = "Eco -  Sales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12.18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(42, 77);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 1;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12.18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(42, 135);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12.18F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(573, 133);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 3;
            label4.Text = "Quntity:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(163, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(716, 29);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(163, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(673, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 29);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Arial Rounded MT Bold", 12.18F);
            button1.Location = new Point(632, 192);
            button1.Name = "button1";
            button1.Size = new Size(247, 60);
            button1.TabIndex = 7;
            button1.Text = "+ Add to Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 9.969231F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(513, 557);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 31);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Font = new Font("Arial Rounded MT Bold", 11.07F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(756, 540);
            button2.Name = "button2";
            button2.Size = new Size(134, 62);
            button2.TabIndex = 23;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 8.86F);
            button3.Location = new Point(89, 555);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 24;
            button3.Text = "Clear Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 8.86F);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.861538F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Price, Quantity, Total });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.861538F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(89, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(731, 243);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 7;
            ProductID.Name = "ProductID";
            ProductID.Width = 135;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 7;
            ProductName.Name = "ProductName";
            ProductName.Width = 135;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.Width = 135;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.Width = 135;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 7;
            Total.Name = "Total";
            Total.Width = 135;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 29);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12.18F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(42, 192);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 27;
            label6.Text = "Sale Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 12.18F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(42, 250);
            label7.Name = "label7";
            label7.Size = new Size(124, 26);
            label7.TabIndex = 28;
            label7.Text = "Cart Items";
            // 
            // button4
            // 
            button4.BackColor = Color.GreenYellow;
            button4.Font = new Font("Arial Rounded MT Bold", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(342, 557);
            button4.Name = "button4";
            button4.Size = new Size(152, 35);
            button4.TabIndex = 29;
            button4.Text = "Grand Total:";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Location = new Point(758, 608);
            button5.Name = "button5";
            button5.Size = new Size(132, 34);
            button5.TabIndex = 30;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Monochrome_Neon_Gadget_Logo___Copy;
            ClientSize = new Size(926, 651);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
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
            Load += Sales_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Button button4;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Button button5;
    }
}
