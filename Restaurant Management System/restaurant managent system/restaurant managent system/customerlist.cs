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
    public partial class customerlist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        public customerlist()
        {
            InitializeComponent();
        }

        private void customerlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet2.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.restaurantdbDataSet2.customertbl);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searachcmb.Text == "")
            {
                MessageBox.Show("select search type");
            }
            else if (searchvaluetxt.Text == "")
            {
                MessageBox.Show("Plz Input search value");
            }
            else
            {
                
                if (searachcmb.Text == "CustomerID")
                {
                    string query = "select *from customertbl where customerId='" + searchvaluetxt.Text + "'";
                    displaydata(query);
                }
                else if (searachcmb.Text == "CustomerName")
                {

                    string query = "select *from customertbl where customerName like '%" + searchvaluetxt.Text + "%'";
                    displaydata(query);
                }
                else if (searachcmb.Text == "CustomerEmail")
                {

                    string query = "select *from customertbl where customerEmail like '%" + searchvaluetxt.Text + "%'";
                    displaydata(query);
                }
                else if (searachcmb.Text == "CustomerPhoneNo")
                {

                    string query = "select *from customertbl where customerPhoneNo like '%" + searchvaluetxt.Text + "%'";
                    displaydata(query);
                }
                else
                {

                    string query = "select *from customertbl where customerAddress like '%" + searchvaluetxt.Text + "%'";
                    displaydata(query);
                }
                
                
            }
        }
        public void displaydata(string query)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bookinglistgb.DataSource = dt;
            con.Close();
        }

        private void showtable_Click(object sender, EventArgs e)
        {
            string query = "select *from customertbl";
            displaydata(query);
        }

        private void searachcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
