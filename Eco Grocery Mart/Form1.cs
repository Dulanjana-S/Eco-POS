
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Eco_Grocery_Mart

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Standard design settings
            //  this.Size = new Size(1200, 800);
            // this.StartPosition = FormStartPosition.CenterScreen;
            // this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resize
            // this.MaximizeBox = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)


       {
            string username = textBox1.Text;
            string password = textBox2.Text;

            //username == "admin" && password == "1234")

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                // Navigate to main form
                /* this.Hide();
                 new Login().Show();  // change Form1 to your real main form name */

        /*                this.Hide();                // Hide the login form
                        Dashboard Dashboard = new Dashboard(); // Create dashboard form
                        Dashboard.Show();     // Open dashboard as a modal dialog

                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.");
                    }
                }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            //username == "admin" && password == "1234")

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                // Navigate to main form
                /* this.Hide();
                 new Login().Show();  // change Form1 to your real main form name */

                this.Hide();                // Hide the login form
                Dashboard Dashboard = new Dashboard(); // Create dashboard form
                Dashboard.Show();     // Open dashboard as a modal dialog

            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }
    }
}