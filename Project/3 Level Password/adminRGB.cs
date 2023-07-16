using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace WindowsFormsApplication1
{
    public partial class adminRGB : Form
    {
        string s;
        public adminRGB( string s1)
        {
            s = s1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Red ,");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Green ,");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txrepass.AppendText("Blue ,");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3V17HN\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (txrepass.Text.Trim() != "")
                {
                    SqlCommand cmd = new SqlCommand("Insert into Rgb values('" + s + "', @pattern)", con);
                    cmd.Parameters.AddWithValue("@pattern", txrepass.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult d = MessageBox.Show("Level Saved Successfully", "Password Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        this.Hide();
                        Form1 p = new Form1(s);
                        p.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Pattern", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
