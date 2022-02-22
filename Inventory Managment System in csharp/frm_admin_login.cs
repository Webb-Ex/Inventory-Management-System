using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Managment_System_in_csharp
{
    public partial class frm_admin_login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        DataTable dt = new DataTable();

        public frm_admin_login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else 
                {
                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From db_admin Where adminname = '" + txt_Username.Text + "' and adminpassword = '" + txt_Password.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        frm_Home fh = new frm_Home();
                        this.Hide();
                        fh.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void frm_admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
