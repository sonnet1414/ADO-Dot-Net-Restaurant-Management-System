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
using System.Text.RegularExpressions;

namespace restaurant_managent_system
{
    public partial class updatebooking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        
        public updatebooking()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updatebooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet.bookingtbl' table. You can move, or remove it, as needed.
            this.bookingtblTableAdapter.Fill(this.restaurantdbDataSet.bookingtbl);

        }

        private void bookinggridview_MouseClick(object sender, MouseEventArgs e)
        {
            bookingidtxt.Text = bookinggridview.SelectedRows[0].Cells[0].Value.ToString();
            bookingdatetxt.Text = bookinggridview.SelectedRows[0].Cells[1].Value.ToString(); 
            guesttxt.Text = bookinggridview.SelectedRows[0].Cells[4].Value.ToString();
            tabletxt.Text = bookinggridview.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void showtablebtn_Click(object sender, EventArgs e)
        {
            string query = "select *from bookingtbl";
            displaydata(query);

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (bookingidtxt.Text == "" || bookingdatetxt.Text == "" || initialtcb.Text == "" || p1tcb.Text == "" || finaltcb.Text == "" || p2tcb.Text == "" || guesttxt.Text == "" || tabletxt.Text == "")
            {
                MessageBox.Show("Data Can not be Empty");
            }
            else
            {
                updatedata();
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
            bookinggridview.DataSource = dt;
            con.Close();
        }
        public void updatedata()
        {
            con.Open();
            string t1 = initialtcb.Text + p1tcb.Text;
            string t2 = finaltcb.Text + p2tcb.Text;
            string query = "update bookingtbl set bookingDate='" + bookingdatetxt.Text + "',bookingStartTime='" + t1 + "',bookingEndTime='" + t2 + "',NoOfGuest='" + guesttxt.Text + "',NoOfTable='" + tabletxt.Text + "' where bookingId='" + bookingidtxt.Text + "'";
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
            bookingdatetxt.Text = "";
            guesttxt.Text = "";
            tabletxt.Text = "";
        }
        /*
            string a = bookinggridview.SelectedRows[0].Cells[2].Value.ToString();
            Regex ire = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = ire.Match(a);
            string alphaPart = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;
            initialtcb.Text = alphaPart;
            p1tcb.Text = numberPart;
            a = bookinggridview.SelectedRows[0].Cells[2].Value.ToString();
            Regex fre = new Regex(@"([a-zA-Z]+)(\d+)");
            result = fre.Match(a);
            alphaPart = result.Groups[1].Value;
            numberPart = result.Groups[2].Value;
            finaltcb.Items.Add(alphaPart);
            p2tcb.Items.Add(numberPart);
         */
    }
}
