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
            InitializeComponent();

            //  settings
          //  this.Size = new Size(1200, 800);
         //   this.StartPosition = FormStartPosition.CenterScreen;
          //  this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resize
          //  this.MaximizeBox = true;


            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        private void OpenFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        /*    //BUTTONS TO PANEl 
            private void button1_Click(object sender, EventArgs e)
            {
                panel1.Controls.Clear();
                Product_Manager pmControl = new Product_Manager();
                pmControl.Dock = DockStyle.Fill;
                panel1.Controls.Add(pmControl);

            }

            private void button2_Click(object sender, EventArgs e)
            {
                panel1.Controls.Clear();
                Sales sbControl = new Sales();
                sbControl.Dock = DockStyle.Fill;
                panel1.Controls.Add(sbControl);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                panel1.Controls.Clear();
                SalesHistory shControl = new SalesHistory();
                shControl.Dock = DockStyle.Fill;
               panel1.Controls.Add(shControl);

            }*/


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
            // Hide or close the Dashboard
            this.Hide();

            // Show the Login form again
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // can add new window in  forms
      /*  private void btnbutton1_Click(object sender, EventArgs e)
        {
            Product_Manager products = new Product_Manager();
            products.Show();

        }

        private void btnbutton2_Click(object sender, EventArgs e)
        {
            Sales products = new Sales();
            products.Show();
        }

        private void btnbutton3_Click(object sender, EventArgs e)
        {
            SalesHistory history = new SalesHistory();
            history.Show();
        }
      */

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Product_Manager());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Sales());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new SalesHistory());

        }
    }
}
