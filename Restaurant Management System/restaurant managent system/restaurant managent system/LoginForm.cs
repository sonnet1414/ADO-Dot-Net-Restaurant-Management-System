using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace restaurant_managent_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu";
            con.Open();
            string query = "select userid,passcode from usertbl where userid='" + usertxt.Text + "'and passcode='" + passtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                home obj = new home();
                obj.Show();
                this.Hide();
                con.Close();

            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
