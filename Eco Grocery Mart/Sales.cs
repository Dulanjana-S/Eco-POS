using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Eco_Grocery_Mart
{
    public partial class Sales : Form
    {
        public Sales()
        {
        // InitializeComponent();
         //((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
         // this.Load += new System.EventHandler(this.Sales_Load);
          // comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

          InitializeComponent();
        //  this.Load += Sales_Load;
           //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        // InitializeComponent();
        public class CartItem
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Total => Quantity * Price;
        }

        // Cart to hold added items
        List<CartItem> cart = new List<CartItem>();

        // Connection string
        private readonly string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True";

        private void LoadProductsToComboBox(object sender, EventArgs e)
        {
            
        LoadProducts();
            EnableAutoComplete();
            //EnablecomboBox1AutoComplete();
        }


        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
            // using (SqlConnection con = new SqlConnection(connectionString))

            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, Name FROM ProductManager", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)

                {
                    MessageBox.Show("No products found in ProductManager table.");
                }

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ProductID";
            }
        }

        private void EnableAutoComplete() //EnablecomboBox1AutoComplete()
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void Sales_Load() //LoadProductsToComboBox()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
            {
                string query = "SELECT ProductID, Name FROM ProductManager";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";       // What the user sees
                comboBox1.ValueMember = "ProductID";    // What you use in code (SelectedValue)
            }
        }

        /*private void LoadProductsToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM ProductManager", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Name"].ToString());
                }
            }
        }*/


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;

            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out int productId))
                return;

            // Optional: get more info (e.g., price)
            decimal price = GetProductPriceById(productId);
            textBox1.Text = $"Price: Rs. {price:N2}"; // example
        }
        private decimal GetProductPriceById(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Price FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", productId);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }


        /*  { 
              if (comboBox1.SelectedValue == null)
                  return;

              if (!int.TryParse(comboBox1.SelectedValue.ToString(), out int productId))
                  return;  
          }*/

        //ADD TO CART Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (comboBox1.SelectedValue == null || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            int productId = Convert.ToInt32(comboBox1.SelectedValue);
            string name = comboBox1.Text;

            if (!int.TryParse(textBox2.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

           decimal price = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM ProductManager WHERE ProductID = @id", con); // Corrected table
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                price = (decimal)cmd.ExecuteScalar();
                con.Close();
            }
 
            var item = new CartItem
            {
                ProductID = productId,
                Name = name,
                Quantity = qty,
                Price = price
            };

            cart.Add(item);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cart;

            textBox3.Text = "Total: Rs. " + cart.Sum(i => i.Total);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // You can remove other empty event handlers unless needed
    }
}
/*
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eco_Grocery_Mart
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        List<CartItem> cart = new List<CartItem>();

        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, Name FROM ProductManager", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ProductID";
            }
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            EnableAutoComplete();
        }
        private void EnableAutoComplete()
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int productId;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out productId)) return;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM ProductManager WHERE ProductID = @id", con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                textBox1.Text = result?.ToString() ?? "";
            }
        }

        /* {
            int productId = Convert.ToInt32(comboBox1.SelectedValue);

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM ProductManager WHERE ProductID = @id", con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }
        */


/*   private void LoadProducts()
   {
       using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
       {
           SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, Name FROM ProductManager", con);
           DataTable dt = new DataTable();
           da.Fill(dt);
           comboBox1.DataSource = dt;
           comboBox1.DisplayMember = "Name";
           comboBox1.ValueMember = "ProductID";
       }
   }
   private void EnableAutoComplete()
   {
       comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
       comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
       comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
   }

   private void SalesForm_Load(object sender, EventArgs e)
   {
       LoadProducts();
       EnableAutoComplete();
   }
   */




/*
private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
           
        {
            int productId = Convert.ToInt32(comboBox1.SelectedValue);
            string name = comboBox1.Text;
            int qty = int.Parse(textBox2.Text);


            decimal price = 0;

            // private string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True";
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True"))
           // using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM Products WHERE ProductID = @id", con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                price = (decimal)cmd.ExecuteScalar();
            }

            var item = new CartItem { ProductID = productId, ProductName = name, Quantity = qty, Price = price };
            cart.Add(item);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cart;
            textBox3.Text = "Total: Rs. " + cart.Sum(i => i.Total);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

*/