
using Microsoft.Data.SqlClient;


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
        
             {
                 string username = textBox1.Text;
                 string password = textBox2.Text;

            SqlConnection con = DB.GetConnection();
            
            {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = admin AND Password = 1234", con);
        cmd.Parameters.AddWithValue("admin", username);
        cmd.Parameters.AddWithValue("1234", password);
        int count = (int)cmd.ExecuteScalar();

        if (count > 0)
        {
            // Login success
            MessageBox.Show("Login Successful!");

            Dashboard dashboard = new Dashboard();
            this.Hide(); // Hide login
            dashboard.Show(); // Show dashboard
        }
        else
        {
            MessageBox.Show("Invalid username or password.");
                     }
                 }
             }
       

        /*{
            string username = textBox1.Text;
            string password = textBox2.Text;

            //username == "admin" && password == "1234")

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                // Navigate to main form
                this.Hide();
                new Login().Show();  // change Form1 to your real main form name
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }*/

private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 