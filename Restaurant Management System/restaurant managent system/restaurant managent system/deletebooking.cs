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
    public partial class deletebooking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
    
        public deletebooking()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showtablebtn_Click(object sender, EventArgs e)
        {
            string query = "select *from bookingtbl";
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
            bookinggridview.DataSource = dt;
            con.Close();
        }

        private void bookinggridview_MouseClick(object sender, MouseEventArgs e)
        {
            bookingidtxt.Text = bookinggridview.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void deletebooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet.bookingtbl' table. You can move, or remove it, as needed.
            this.bookingtblTableAdapter.Fill(this.restaurantdbDataSet.bookingtbl);

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (bookingidtxt.Text == "")
            {
                MessageBox.Show("Enter the Booking ID");
            }
            else
            {
                deletedata();
 
            }
        }
        public void deletedata()
        {
            con.Open();
            string query = "delete from bookingtbl where bookingId='" + bookingidtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            query = "select *from bookingtbl";
            displaydata(query);
            clear();
        }
        public void clear()
        {
            bookingidtxt.Text = "";
        }
    }
}
