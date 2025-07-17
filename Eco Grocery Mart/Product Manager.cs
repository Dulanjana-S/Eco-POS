using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;





namespace Eco_Grocery_Mart
{
    public partial class Product_Manager : Form
    {
        public Product_Manager()
        {
            InitializeComponent();
            // LoadProducts(); // Call method when form loads */

            // Standard design settings
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resize
            this.MaximizeBox = true;


        }

        //db connection
        // SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True");

        //string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True";
        string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        // string connectionString = "Server=DESKTOP-O3R14AN\\SQLEXPRESS;Database==EcoMart_POS;User Id=admin;Password=1234;Encrypt=True;TrustServerCertificate=True;";




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Product_Manager_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Price"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();
            }
        }


        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ProductManager", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }





        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /*    {

               if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
           {
               con.Open();
               SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Price, Quantity) VALUES (@name, @price, @qty)", con);
               cmd.Parameters.AddWithValue("@name", textBox1.Text);
               //cmd.Parameters.AddWithValue("@cat", txtCategory.Text); //deleted
               cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox3.Text));
               cmd.Parameters.AddWithValue("@qty", int.Parse(textBox4.Text));
               cmd.ExecuteNonQuery();
               con.Close();

               MessageBox.Show("Product added successfully.");
               LoadProducts();
               ClearFields();
           }
           else
           {
               MessageBox.Show("Fill all fields.");
           }
       }
     */
        private void button2_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ProductManager SET Name=@name, Price=@price, Quantity=@qty WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@qty", int.Parse(textBox4.Text));
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Product updated.");
                LoadProducts();
                ClearFields();
            }
        }



        private void button1_Click_1(object sender, EventArgs e)

        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ProductManager (Name, Price, Quantity) VALUES (@name, @price, @qty)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@qty", int.Parse(textBox4.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Product added successfully.");
                LoadProducts();  // refresh grid
                ClearFields();   // reset inputs 
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void button3_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ProductManager WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Product deleted.");
                LoadProducts();
                ClearFields();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ProductManager WHERE Name LIKE @search", con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox5.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Close();
            //this.Close();  // or this.Hide();
        }

    }
}





