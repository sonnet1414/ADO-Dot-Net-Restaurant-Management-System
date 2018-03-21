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
    public partial class customermanagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
    
        public customermanagement()
        {
            InitializeComponent();
        }

        private void customermanagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet2.customertbl' table. You can move, or remove it, as needed.
            this.customertblTableAdapter.Fill(this.restaurantdbDataSet2.customertbl);

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
            customergridview.DataSource = dt;
            con.Close();
        }

        private void customergridview_MouseClick(object sender, MouseEventArgs e)
        {
            customeridtxt.Text = customergridview.SelectedRows[0].Cells[0].Value.ToString();
            customernametxt.Text = customergridview.SelectedRows[0].Cells[1].Value.ToString();
            customeremailtxt.Text = customergridview.SelectedRows[0].Cells[2].Value.ToString();
            customerphonenotxt.Text = customergridview.SelectedRows[0].Cells[3].Value.ToString();
            customeraddresstxt.Text = customergridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void showtable_Click(object sender, EventArgs e)
        {
            string query = "select *from customertbl";
            displaydata(query);
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (customeridtxt.Text == "" || customernametxt.Text == "" || customeremailtxt.Text == "" || customerphonenotxt.Text == "" || customeraddresstxt.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                insertdata();
            }
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (customeridtxt.Text == "" || customernametxt.Text == "" || customeremailtxt.Text == "" || customerphonenotxt.Text == "" || customeraddresstxt.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                updatedata();
            }
            

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (customeridtxt.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                deletedata();
            }
            

        }
        public void insertdata()
        {
            con.Open();
            string query = "insert into customertbl (customerId,customerName,customerEmail,customerPhoneNo,customerAddress)values(@customerId,@customerName,@customerEmail,@customerPhoneNo,@customerAddress)";
            SqlCommand bcmd = new SqlCommand(query, con);
            bcmd.Parameters.Add("@customerId", customeridtxt.Text);
            bcmd.Parameters.Add("@customerName", customernametxt.Text);
            bcmd.Parameters.Add("@customerEmail", customeremailtxt.Text);
            bcmd.Parameters.Add("@customerPhoneNo", Convert.ToInt32(customerphonenotxt.Text));
            bcmd.Parameters.Add("@customerAddress", customeraddresstxt.Text);
            bcmd.ExecuteNonQuery();
            con.Close();
            query = "select *from customertbl";
            displaydata(query);
            clear();
        }
        public void updatedata()
        {
            con.Open();
            string query = "update customertbl set customerName='" + customernametxt.Text + "',customerEmail='" + customeremailtxt.Text + "',customerPhoneNo='" + Convert.ToInt32(customerphonenotxt.Text) + "',customerAddress='" + customeraddresstxt.Text + "' where customerId='" + customeridtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            
            con.Close();
            query = "select *from customertbl";
            displaydata(query);
            clear();
        }
        public void deletedata()
        {
            con.Open();
            string query = "delete from customertbl where customerId='" + customeridtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            
            con.Close();
            query = "select *from customertbl";
            displaydata(query);
            clear();
        }
        public void clear()
        {
            customeridtxt.Text = "";
            customernametxt.Text = "";
            customeremailtxt.Text = "";
            customerphonenotxt.Text = "";
            customeraddresstxt.Text = "";
        }

        private void generatecusID_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.ToString("yyyyMMddHHmmss");
            s = "C" + s;
            customeridtxt.Text = s;
        }
    }
}
