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
    public partial class orderlist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        public orderlist()
        {
            InitializeComponent();
        }

        private void orderlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet5.ordertbl' table. You can move, or remove it, as needed.
            this.ordertblTableAdapter.Fill(this.restaurantdbDataSet5.ordertbl);

        }

        private void searachcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searachcmb.Text == "DeliveryDate")
            {
                searchvaluetxt.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                clear();
                dateTimePicker1.Visible = false;
                searchvaluetxt.Visible = true;
            }
        }
        public void clear()
        {
            searchvaluetxt.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searachcmb.Text == "")
            {
                MessageBox.Show("select search type");
            }
            else if (searchvaluetxt.Text == "" && searachcmb.Text !="DeliveryDate")
            {
                MessageBox.Show("Enter search value");
            }
            else if (searachcmb.Text == "CustomerID")
            {
                string query = "select *from ordertbl where customerId='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "OrderID")
            {

                string query = "select *from ordertbl where orderId='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "DeliveryDate")
            {
                string query = "select *from ordertbl where deliveryDate='" + dateTimePicker1.Text + "'";
                displaydata(query);
            }
            else
            {
                MessageBox.Show("Data not Found");
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
            clear();
        }

        private void showtable_Click(object sender, EventArgs e)
        {
            string query = "select *from ordertbl";
            displaydata(query);
        }
    }
}
