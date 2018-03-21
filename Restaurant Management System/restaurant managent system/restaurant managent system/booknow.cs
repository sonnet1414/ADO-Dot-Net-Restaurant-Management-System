using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace restaurant_managent_system
{
    public partial class booknow : Form
    {
        public booknow()
        {
            InitializeComponent();
        }
        private void booknow_Load(object sender, EventArgs e)
        {
            cusidlbl.Visible = false;
            cusidtxt.Visible= false;
            fetchbtn.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
             string id = cnametxt.Text;
                string query = "select *from customertbl where customerId=id";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter mdr = new SqlDataAdapter();
                DataTable sa = new DataTable();
                mdr.Fill(sa);
                BindingSource bsource = new BindingSource();
             */
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; 
            string s = dt.ToString("yyyyMMddHHmmss");

            if (customerchkbox.Checked)
            {
                if(initialtcb.Text=="" || p1tcb.Text=="" || finaltcb.Text=="" || p2tcb.Text=="")
                {
                    MessageBox.Show("Booking Field can not be empty");
                }
                else if (cusidtxt.Text == "")
                {
                    MessageBox.Show("Enter Customer ID");
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu";
                    con.Open();

                    string id2 = "B";
                    id2 = id2 + s;
                    string t1 = initialtcb.Text + p1tcb.Text;
                    string t2 = finaltcb.Text + p2tcb.Text;
                    string query = "insert into bookingtbl (bookingId,bookingDate,bookingStartTime,bookingEndTime,NoOfGuest,NoOfTable)values(@bookingId,@bookingDate,@bookingStartTime,@bookingEndTime,@NoOfGuest,@NoOfTable)";
                    SqlCommand bcmd = new SqlCommand(query, con);
                    bcmd.Parameters.Add("@bookingId", id2);
                    bcmd.Parameters.Add("@bookingDate", bookingdate.Text);
                    bcmd.Parameters.Add("@bookingStartTime", t1);
                    bcmd.Parameters.Add("@bookingEndTime", t2);
                    bcmd.Parameters.Add("@NoOfGuest", Convert.ToInt32(guesttxt.Text));
                    bcmd.Parameters.Add("@NoOfTable", Convert.ToInt32(tabletxt.Text));
                    bcmd.ExecuteNonQuery();

                    query = "insert into customerbookingtbl (customerId,bookingId)values(@customerId,@bookingId)";
                    SqlCommand cbcmd = new SqlCommand(query, con);
                    cbcmd.Parameters.Add("@customerId", cusidtxt.Text);
                    cbcmd.Parameters.Add("@bookingId", id2);
                    cbcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Booking Successful");
                    clear();
 
                }

            }
            else
            {
                if (initialtcb.Text == "" || p1tcb.Text == "" || finaltcb.Text == "" || p2tcb.Text == "")
                {
                    MessageBox.Show("Booking Field can not be empty");
                }
                else if (cnametxt.Text == "" || cemailtxt.Text == "" || cphonetxt.Text == "" || caddressrtxt.Text == "")
                {
                    MessageBox.Show("Customer Field Can not be Empty");
                }
                else
                {
                    string id1 = "C";
                    id1 = id1 + s;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu";
                    con.Open();
                    string query = "insert into customertbl (customerId,customerName,customerEmail,customerPhoneNo,customerAddress)values(@customerId,@customerName,@customerEmail,@customerPhoneNo,@customerAddress)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@customerId", id1);
                    cmd.Parameters.Add("@customerName", cnametxt.Text);
                    cmd.Parameters.Add("@customerEmail", cemailtxt.Text);
                    cmd.Parameters.Add("@customerPhoneNo", Convert.ToInt32(cphonetxt.Text));
                    cmd.Parameters.Add("@customerAddress", caddressrtxt.Text);
                    cmd.ExecuteNonQuery();

                    string id2 = "B";
                    id2 = id2 + s;
                    string t1 = initialtcb.Text + p1tcb.Text;
                    string t2 = finaltcb.Text + p2tcb.Text;
                    query = "insert into bookingtbl (bookingId,bookingDate,bookingStartTime,bookingEndTime,NoOfGuest,NoOfTable)values(@bookingId,@bookingDate,@bookingStartTime,@bookingEndTime,@NoOfGuest,@NoOfTable)";
                    SqlCommand bcmd = new SqlCommand(query, con);
                    bcmd.Parameters.Add("@bookingId", id2);
                    bcmd.Parameters.Add("@bookingDate", bookingdate.Text);
                    bcmd.Parameters.Add("@bookingStartTime", t1);
                    bcmd.Parameters.Add("@bookingEndTime", t2);
                    bcmd.Parameters.Add("@NoOfGuest", Convert.ToInt32(cphonetxt.Text));
                    bcmd.Parameters.Add("@NoOfTable", Convert.ToInt32(cphonetxt.Text));
                    bcmd.ExecuteNonQuery();

                    query = "insert into customerbookingtbl (customerId,bookingId)values(@customerId,@bookingId)";
                    SqlCommand cbcmd = new SqlCommand(query, con);
                    cbcmd.Parameters.Add("@customerId", id1);
                    cbcmd.Parameters.Add("@bookingId", id2);
                    cbcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Booking Successful");
                    clear();
 
                }
                
            }

        }

        private void customerchkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (customerchkbox.Checked)
            {
                cusidlbl.Visible = true;
                cusidtxt.Visible = true;
                fetchbtn.Visible = true;
            }
            else
            {
                cusidlbl.Visible = false;
                cusidtxt.Visible = false;
                fetchbtn.Visible = false;
 
            }
            
        }

        private void fetchbtn_Click(object sender, EventArgs e)
        {
            if (cusidtxt.Text == "")
            {
                MessageBox.Show("Plz Enter the Customer ID");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu";
                con.Open();
                string query = "select *from customertbl where customerId='" + cusidtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cnametxt.Text = (dr["customerName"].ToString());
                    cemailtxt.Text = (dr["customerEmail"].ToString());
                    cphonetxt.Text = (dr["customerPhoneNo"].ToString());
                    caddressrtxt.Text = (dr["customerAddress"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not Found");
                }
                con.Close();
 
            }

        }
        public void clear()
        {
            cusidtxt.Text = "";
            cnametxt.Text = "";
            cemailtxt.Text = "";
            cphonetxt.Text = "";
            caddressrtxt.Text = "";
            guesttxt.Text = "";
            tabletxt.Text = "";
        }
        
    }
}
