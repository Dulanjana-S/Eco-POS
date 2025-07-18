namespace Eco_Grocery_Mart
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(107, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(107, 439);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 29);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8.861538F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(134, 499);
            button1.Name = "button1";
            button1.Size = new Size(105, 31);
            button1.TabIndex = 8;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 651);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
      //  private Button button1;
    }
}
