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
            InitializeComponent();

            ResumeLayout(false);
            PerformLayout();
            this.Load += new System.EventHandler(this.Sales_Load); // 🔥 Add this


        }
        string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";


        private void LoadProductsTocomboBox1()
        {

            MessageBox.Show("Loading products..."); // Debug line

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, Name FROM ProductManager", con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                // da.Fill(dt);

                MessageBox.Show("Rows loaded: " + dt.Rows.Count); // Debug line

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ProductID";

                MessageBox.Show("Loaded: " + dt.Rows.Count + " products");

                //product


            }

        }


        bool isFormLoading = true;

        private void Sales_Load(object sender, EventArgs e)
        {
            isFormLoading = true;

            LoadProductsTocomboBox1();
         //   SetupCartGrid();

            isFormLoading = false;

        }

        private void SetupCartGrid()
       {
            
            dataGridView1.Columns.Add("ProductID", "ProductID");
           // dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns.Add("ProductName", "Product");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Total", "Total");
            ;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return; // prevent loading-time errors

            if (comboBox1.SelectedValue == null) return;

            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out int ProductId)) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price FROM ProductManager WHERE ProductID = @id", con);
                cmd.Parameters.AddWithValue("@id", ProductId);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                textBox1.Text = result?.ToString() ?? "";
            }
        }



        //ADD TO CART Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                return;

            int productId = (int)comboBox1.SelectedValue;
            string name = comboBox1.Text;
            decimal price = decimal.Parse(textBox1.Text);
            int qty = int.Parse(textBox2.Text);
            decimal total = price * qty;

            dataGridView1.Rows.Add(productId, name, price, qty, total);

        }

        private void UpdateGrandTotal()

        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowTotal))
                {
                    grandTotal += rowTotal;
                }
            }

            textBox3.Text = grandTotal.ToString("N2"); // Format as currency

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //GrandTotal 
        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();         // Clear all rows from cart
            textBox3.Text = "0.00";             // Reset Grand Total    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate Total Amount
                decimal totalAmount = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Total"].Value != null)
                        totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
                }

                int saleID;

                // Insert into Sales table
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertSale = "INSERT INTO Sales (TotalAmount) OUTPUT INSERTED.SaleID VALUES (@total)";
                    SqlCommand cmd = new SqlCommand(insertSale, con);
                    cmd.Parameters.AddWithValue("@total", totalAmount);
                    saleID = (int)cmd.ExecuteScalar();

                    // Insert each item into SalesHistory
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                        SqlCommand detailCmd = new SqlCommand(
                            "INSERT INTO SalesHistory (SaleID, ProductID, Quantity, Price) VALUES (@saleID, @productID, @qty, @price)", con);

                        detailCmd.Parameters.AddWithValue("@saleID", saleID);
                        detailCmd.Parameters.AddWithValue("@productID", productId);
                        detailCmd.Parameters.AddWithValue("@qty", qty);
                        detailCmd.Parameters.AddWithValue("@price", price);

                        detailCmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                // Open Invoice Form
                Invoice invoiceForm = new Invoice(saleID, totalAmount);
                invoiceForm.Show();

                MessageBox.Show("Sale completed and invoice generated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: Clear cart and total
                dataGridView1.Rows.Clear();
                textBox3.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* {
        // : Calculate totalAmount
        decimal totalAmount = 0;
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.Cells["Total"].Value != null)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }
        }

        // Insert into Sales table and get the SaleID
        int saleID;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string insertSale = "INSERT INTO Sales (TotalAmount) OUTPUT INSERTED.SaleID VALUES (@total)";
            SqlCommand cmd = new SqlCommand(insertSale, con);
            cmd.Parameters.AddWithValue("@total", totalAmount);

            con.Open();
            saleID = (int)cmd.ExecuteScalar(); // Gets the new SaleID
            con.Close();
        }

        //  Pass to Invoice form
        Invoice invoiceForm = new Invoice(saleID, totalAmount);
        invoiceForm.Show();


        // Invoice invoiceForm = new Invoice (saleID, totalAmount);
        //  invoiceForm.Show();

    }
*/

        /*  private void button4_Click(object sender, EventArgs e)
          {
              {
                  decimal grandTotal = 0;

                  foreach (DataGridViewRow row in dataGridView1.Rows)
                  {
                      if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowTotal))
                      {
                          grandTotal += rowTotal;
                      }
                  }

                  textBox3.Text = grandTotal.ToString("N2"); // Show with 2 decimal places

              }
          }*/

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ignore the new blank row at the bottom of DataGridView (if AllowUserToAddRows = true)
                if (row.IsNewRow)
                    continue;

                // Read "Total" cell value
                object totalValue = row.Cells["Total"].Value;

                if (totalValue != null && decimal.TryParse(totalValue.ToString(), out decimal rowTotal))
                {
                    grandTotal += rowTotal;
                }
            }

            textBox3.Text = grandTotal.ToString("N2"); // Show 2 decimal places
       
    }

    // You can remove other empty event handlers unless needed
}
}
