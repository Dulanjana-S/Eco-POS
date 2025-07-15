namespace Eco_Grocery_Mart
{
    partial class Product_Manager
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8.861538F, FontStyle.Bold);
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8.861538F, FontStyle.Bold);
            label3.Location = new Point(25, 110);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8.861538F, FontStyle.Bold);
            label4.Location = new Point(373, 110);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(123, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(574, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(123, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(466, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 29);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 8.861538F);
            button1.Location = new Point(25, 173);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Arial Rounded MT Bold", 8.861538F);
            button2.Location = new Point(205, 173);
            button2.Name = "button2";
            button2.Size = new Size(128, 35);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Arial Rounded MT Bold", 8.861538F);
            button3.Location = new Point(382, 173);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.Font = new Font("Arial Rounded MT Bold", 8.861538F);
            button4.Location = new Point(569, 173);
            button4.Name = "button4";
            button4.Size = new Size(128, 35);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.969231F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 254);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 16;
            label5.Text = "Product List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 250);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 17;
            label6.Text = "Search:";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(466, 246);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 29);
            textBox5.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(25, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(672, 227);
            dataGridView1.TabIndex = 19;
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
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 135;
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 135;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            Column4.Width = 135;
            // 
            // Column5
            // 
            Column5.HeaderText = "Qty";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            Column5.Width = 135;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 9);
            label7.Name = "label7";
            label7.Size = new Size(220, 23);
            label7.TabIndex = 20;
            label7.Text = "Product Management";
            // 
            // Product_Manager
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 535);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Product_Manager";
            Text = "Product_Management";
            Load += Product_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label7;
    }
}