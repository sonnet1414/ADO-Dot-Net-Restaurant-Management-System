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
    public partial class deleteorder : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
    
        public deleteorder()
        {
            InitializeComponent();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (orderidtxt.Text == "")
            {
                MessageBox.Show("select the OrderID");
            }
            else
            {
                deletedata();

            }
        }

        private void deleteorder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet5.ordertbl' table. You can move, or remove it, as needed.
            this.ordertblTableAdapter.Fill(this.restaurantdbDataSet5.ordertbl);

        }

        private void ordergridview_MouseClick(object sender, MouseEventArgs e)
        {
            orderidtxt.Text = ordergridview.SelectedRows[0].Cells[0].Value.ToString();
        }
        public void deletedata()
        {
            con.Open();
            string query = "delete from ordertbl where orderId='" + orderidtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            query = "select *from ordertbl";
            displaydata(query);
            clear();
        }
        public void clear()
        {
            orderidtxt.Text = "";
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
            ordergridview.DataSource = dt;
            con.Close();
        }

        private void showtablebtn_Click(object sender, EventArgs e)
        {
            string query = "select *from ordertbl";
            displaydata(query);
            clear();
        }
    }
}
