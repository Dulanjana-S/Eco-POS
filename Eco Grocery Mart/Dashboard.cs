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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent(); //very important
        }
        /* public MainForm(string username, string role)
        {
            InitializeComponent();
            currentUser = username;
            currentRole = role;
            lblWelcome.Text = $"Welcome {currentUser} ({currentRole}) to Lak Grocery Mart!";
      
        // Optionally: show/hide buttons based on role
        if (currentRole == "Cashier")
        {
            btnProductManagement.Visible = false;
            btnInventoryReport.Visible = false; 
        } */

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard login = new Dashboard();
            login.Show();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_Manager productForm = new Product_Manager();
            productForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Sales products = new Sales();
            products.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesHistory history = new SalesHistory();
            history.Show();
        }
    }
}
