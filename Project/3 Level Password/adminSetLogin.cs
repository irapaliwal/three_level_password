using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class adminSetLogin : Form
    {
        public adminSetLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtu.Text != "" && txtpass.Text != "")
            {
                
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3V17HN\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                string id = txtu.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from LoginTbl where userid='" + id + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("This UserID already Used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtu.Text = "";
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    if (txtpass.Text.Trim() == txrepass.Text.Trim())
                    {
                        cmd = new SqlCommand("INSERT INTO LoginTbl (userid, pass) VALUES ('" + txtu.Text + "', '" + txtpass.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            adminRGB a = new adminRGB(txtu.Text);
                            a.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all Feilds", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
    }
}
