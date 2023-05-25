using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_managment
{
    public partial class newusers : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public newusers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into usertable(username,fullname,phonenumber,password) values(@username,@fullname,@phonenumber,@password)", conn);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                MessageBox.Show("user added!");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Mainform mainform = new Mainform();
                mainform.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void newManageusers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Clear();
            fullname.Clear();
            phonenumber.Clear();
            password.Clear();
        }
    }
}
