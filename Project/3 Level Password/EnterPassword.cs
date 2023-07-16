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
    public partial class EnterPassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3V17HN\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
        public EnterPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //#region System Generated
            //Class1 c = new Class1();
            //bool c1 = c.checkLoad("S304", con);
            //if (!c1)
            //{
            //    Application.Exit();
            //}
            //#endregion

           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("select * from LoginTbl where userid =@userid and pass=@pass", con);
            cmd.Parameters.AddWithValue("@userid", txtu.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                rgb r = new rgb(txtu.Text);
                r.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
