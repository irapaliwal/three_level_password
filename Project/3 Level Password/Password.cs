using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Password : Form
    {
        string s;
        public Password(string s1)
        {
            s = s1;
            
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            Button1.BackgroundImage = Image.FromFile(@"Image\capturedimage1.jpg");
            Button2.BackgroundImage = Image.FromFile(@"Image\capturedimage2.jpg");
            Button3.BackgroundImage = Image.FromFile(@"Image\capturedimage3.jpg");
            Button4.BackgroundImage = Image.FromFile(@"Image\capturedimage4.jpg");
            Button5.BackgroundImage = Image.FromFile(@"Image\capturedimage5.jpg");
            Button6.BackgroundImage = Image.FromFile(@"Image\capturedimage6.jpg");
            Button7.BackgroundImage = Image.FromFile(@"Image\capturedimage7.jpg");
            Button8.BackgroundImage = Image.FromFile(@"Image\capturedimage8.jpg");
            Button9.BackgroundImage = Image.FromFile(@"Image\capturedimage9.jpg");
        }

        private void Button13_Click(object sender, EventArgs e)
        {

            ListBox.ObjectCollection list = ListBox1.Items;
            Random rng = new Random();
            int n = list.Count;
            //begin updating
            ListBox1.BeginUpdate();
            while (n > 1)
            {
                n -= 1;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            ListBox1.EndUpdate();
            ListBox1.Invalidate();
            {
                string values = ListBox1.Items[0].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button1.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[1].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button2.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[2].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button3.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[3].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button4.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[4].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button5.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[5].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button8.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[6].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button7.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[7].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button6.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            {
                string values = ListBox1.Items[8].ToString();
                string[] tokens = values.Split(',');

                int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                Button9.Location = new Point(convertedItems[0], convertedItems[1]);
            }

            //'''''''''''''''''''''''''2
            //string[] s2 = ListBox1.Items(1).ToString().Split("-");
            //Button2.Location = new Point(s2(0), s2(1));

            //'''''''''''''''''''''''''3
            //string[] s3 = ListBox1.Items(2).ToString().Split("-");
            //Button3.Location = new Point(s3(0), s3(1));

            //'''''''''''''''''''''''''2
            //string[] s4 = ListBox1.Items(3).ToString().Split("-");
            //Button4.Location = new Point(s4(0), s4(1));

            //'''''''''''''''''''''''''2
            //string[] s5 = ListBox1.Items(4).ToString().Split("-");
            //Button5.Location = new Point(s5(0), s5(1));

            //'''''''''''''''''''''''''2
            //string[] s6 = ListBox1.Items(5).ToString().Split("-");
            //Button6.Location = new Point(s6(0), s6(1));

            //'''''''''''''''''''''''''2
            //string[] s7 = ListBox1.Items(6).ToString().Split("-");
            //Button7.Location = new Point(s7(0), s7(1));

            //'''''''''''''''''''''''''2
            //string[] s8 = ListBox1.Items(7).ToString().Split("-");
            //Button8.Location = new Point(s8(0), s8(1));

            //'''''''''''''''''''''''''2
            //string[] s9 = ListBox1.Items(8).ToString().Split("-");
            //Button9.Location = new Point(s9(0), s9(1));

            //'''''''''''''''''''''''''2
            //string[] s10 = ListBox1.Items(9).ToString().Split("-");
            //Button10.Location = new Point(s10(0), s10(1));

            //'''''''''''''''''''''''''2
            //string[] s11 = ListBox1.Items(10).ToString().Split("-");
            //Button11.Location = new Point(s11(0), s11(1));

            //'''''''''''''''''''''''''2
            //string[] s12 = ListBox1.Items(11).ToString().Split("-");
            //Button12.Location = new Point(s12(0), s12(1));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            Button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            Button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            Button3.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            Button4.Enabled = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            Button5.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            Button6.Enabled = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            Button7.Enabled = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            Button8.Enabled = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            Button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3V17HN\SQLEXPRESS;Initial Catalog=ThreeLevelDB;Integrated Security=True");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Insert into Img values('"+s+"','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                DialogResult d = MessageBox.Show("User Registered Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (d == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
