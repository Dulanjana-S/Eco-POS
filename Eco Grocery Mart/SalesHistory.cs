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

namespace Eco_Grocery_Mart
{
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        private void LoadSalesHistory()
        {
            string query = @"
        SELECT 
            S.SaleID,
            S.SaleDate,
            PM.Name AS ProductName,
            SH.Quantity,
            SH.Price,
            SH.Total
        FROM 
            Sales S
        INNER JOIN 
            SalesHistory SH ON S.SaleID = SH.SaleID
        INNER JOIN 
            ProductManager PM ON SH.ProductID = PM.ProductID
        ORDER BY 
            S.SaleDate DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadFilteredSalesHistory(DateTime fromDate, DateTime toDate)
        {
            string query = @"
        SELECT 
            S.SaleID,
            S.SaleDate,
            PM.Name AS ProductName,
            SH.Quantity,
            SH.Price,
            SH.Total
        FROM 
            Sales S
        INNER JOIN 
            SalesHistory SH ON S.SaleID = SH.SaleID
        INNER JOIN 
            ProductManager PM ON SH.ProductID = PM.ProductID
        WHERE 
            S.SaleDate BETWEEN @from AND @to
        ORDER BY 
            S.SaleDate DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@from", fromDate);
                cmd.Parameters.AddWithValue("@to", toDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            LoadSalesHistory();
            LoadFilteredSalesHistory(DateTime.MinValue, DateTime.MaxValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            this.Hide();  // Hide the Product Manager form
            Sales saleForm = new Sales();  // Create instance of your Sale form
            saleForm.Show();  // Show Sale form
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1); // include entire day

            LoadFilteredSalesHistory(fromDate, toDate);
        }
    }
}
