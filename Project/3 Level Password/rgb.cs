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
    public partial class rgb : Form
    {
        string s;
        public rgb(string s1)
        {
            s = s1;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txrepass.AppendText("Red ,");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txrepass.AppendText("Green ,");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txrepass.AppendText("Blue ,");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3V17HN\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select pattern from Rgb where userid='" + s + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (txrepass.Text == Convert.ToString(dr[0]))
                    {
                        DialogResult d = MessageBox.Show("Password Matched", "Level Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (d == DialogResult.OK)
                        {
                            this.Hide();
                            Test t = new Test(s);
                            t.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txrepass.Text = "";
        }

       
    }
}
