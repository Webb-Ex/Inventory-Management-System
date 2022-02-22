using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Managment_System_in_csharp
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            uc_home1.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Categories.Height;
            SidePanel.Top = btn_Categories.Top;
            uc_categories1.BringToFront();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_Products.Height;
            SidePanel.Top = btn_Products.Top;
            uc_Product1.BringToFront();

        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_Customers.Height;
            SidePanel.Top = btn_Customers.Top;
            uc_customers1.BringToFront();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_Orders.Height;
            SidePanel.Top = btn_Orders.Top;
            uc_orders1.BringToFront();
        }

        private void btn_Sales_Invoice_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_Sales_Invoice.Height;
            SidePanel.Top = btn_Sales_Invoice.Top;
            uc_sales_invoice1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btn_users.Height;
            SidePanel.Top = btn_users.Top;
            uc_User1.BringToFront();
            
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            SidePanel.Height = Logout.Height;
            SidePanel.Top = Logout.Top;

            Application.Exit();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            uc_home1.BringToFront();
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/mj_technical_solutions?r=nametag");
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mj.ts.17");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
