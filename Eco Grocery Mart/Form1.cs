
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
       /* {
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = DB.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int userCount = (int)cmd.ExecuteScalar();
                conn.Close();

                if (userCount > 0)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // hide login form
                    new Login().Show(); // replace with your actual main form name
                }

                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       */
   
        {
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
