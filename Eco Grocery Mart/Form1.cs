
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Eco_Grocery_Mart

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
       /* {
            // Assume SQL connection and credential checking are already implemented
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                // Replace this with your own SQL credential check
                //if (log(textBox1.Text, textBox2.Text))
                    if (IsLoginValid(admin, 1234)) 

                {
                    this.Hide();                // Hide the login form
                    Dashboard dashboard = new Dashboard(); // Create dashboard form
                    dashboard.ShowDialog();     // Open dashboard as a modal dialog
                    this.Close();               // Close login form after dashboard is closed
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } */


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
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 