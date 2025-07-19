using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Eco_Grocery_Mart
{

    public partial class Invoice : Form
    {
        private int saleID;
        private decimal totalAmount;
        public Invoice(int saleID, decimal totalAmount)
        {
            InitializeComponent();
            this.saleID = saleID;
            this.totalAmount = totalAmount;
            this.Load += Invoiceform_Load; // Hook up the event here


        }
        private void Invoiceform_Load(object sender, EventArgs e)
        {
            label2.Text = "Sale ID: " + saleID.ToString();
            label3.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            label6.Text = "Total: Rs. " + totalAmount.ToString("N2");

            LoadInvoiceItems();
        }

        private void LoadInvoiceItems()
        {
            string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                //string query = @"SELECT P.Name, SH.Quantity, SH.Price, (SH.Quantity * SH.Price) AS Total
                string query = @"SELECT P.Name, SH.Quantity, SH.Price, (SH.Quantity * SH.Price) AS Total

                         FROM SalesHistory SH
                         JOIN ProductManager P ON P.ProductID = SH.ProductID
                         WHERE SH.SaleID = @saleID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@saleID", saleID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // MessageBox.Show($"Rows loaded: {dt.Rows.Count}");


                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                // content is visible
                /*  dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                  dataGridView1.DefaultCellStyle.BackColor = Color.White; */


                // Calculate total and update label here
                decimal sumTotal = 0;
                foreach (DataRow row in dt.Rows)
                {
                    sumTotal += Convert.ToDecimal(row["Total"]);
                }
                label6.Text = "Total: Rs. " + sumTotal.ToString("N2");
                // MessageBox.Show(dt.Rows.Count + " rows loaded."); // Debug message

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the Invoice form

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
