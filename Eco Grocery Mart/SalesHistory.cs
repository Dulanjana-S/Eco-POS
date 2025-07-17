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

            // Standard design settings
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resize
            this.MaximizeBox = true;

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
            // Ensure SQL-compatible date range
            if (fromDate < new DateTime(1753, 1, 1))
                fromDate = new DateTime(1753, 1, 1);

            if (toDate < new DateTime(1753, 1, 1))
                toDate = new DateTime(1753, 1, 1);

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
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Close();
            // this.Close();  // closes Sales History form

 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1); // include entire day

            LoadFilteredSalesHistory(fromDate, toDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
