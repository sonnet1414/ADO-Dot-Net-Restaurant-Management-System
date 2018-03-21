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
    public partial class bookinglist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        public bookinglist()
        {
            InitializeComponent();
        }

        private void bookinglist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet.bookingtbl' table. You can move, or remove it, as needed.
            this.bookingtblTableAdapter.Fill(this.restaurantdbDataSet.bookingtbl);
            dateTimePicker1.Visible = false;

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showtable_Click(object sender, EventArgs e)
        {
            string query = "select c.customerId,b.bookingId, b.bookingDate,b.bookingStartTime,b.bookingEndTime,b.NoOfGuest,b.NoOftable from bookingtbl as b,customerbookingtbl as c where c.bookingId=b.bookingId";
            displaydata(query);
            
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searachcmb.Text == "")
            {
                MessageBox.Show("select search type");
            }
            else if(searchvaluetxt.Text=="")
            {
                MessageBox.Show("Enter search value");
            }
            else if (searachcmb.Text == "CustomerID")
            {
                string query = "select *from customerbookingtbl,bookingtbl where customerId='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "BookingID")
            {

                string query = "select *from customerbookingtbl,bookingtbl where bookingId='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "BookingDate")
            {
                string query = "select *from customerbookingtbl,bookingtbl where bookingDate='" + dateTimePicker1.Text + "'";
                displaydata(query);
            }
            else
            {
                MessageBox.Show("Data not Found");
            }
        }

        private void searachcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searachcmb.Text == "BookingDate")
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
    }
}
