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
    public partial class itemlist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        public itemlist()
        {
            InitializeComponent();
        }

        private void itemlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet1.itemtbl' table. You can move, or remove it, as needed.
            this.itemtblTableAdapter.Fill(this.restaurantdbDataSet1.itemtbl);
            lowervaluetxt.Visible = false;
            highestvaluetxt.Visible = false;
            limitlbl.Visible = false;

        }

        private void searachcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searachcmb.Text == "ItemPrice")
            {
                clear();
                searchvaluetxt.Visible = false;
                lowervaluetxt.Visible = true;
                highestvaluetxt.Visible = true;
                limitlbl.Visible = true;
            }
            else
            {
                clear();
                lowervaluetxt.Visible = false;
                limitlbl.Visible = false;
                highestvaluetxt.Visible = false;
                searchvaluetxt.Visible = true;
            }
        }
        public void clear()
        {
            searchvaluetxt.Text = "";
            lowervaluetxt.Text = "";
            highestvaluetxt.Text = "";
        }

        private void showtable_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searachcmb.Text == "")
            {
                MessageBox.Show("select search type");
            }
            else if (searchvaluetxt.Text == "")
            {
                MessageBox.Show("Enter search value");
            }
            else if (searachcmb.Text == "ItemPrice")
            {
                if (lowervaluetxt.Text == "" || highestvaluetxt.Text == "")
                {
                    MessageBox.Show("enter lowest and highest value");
                }
                else
                {
                    string query = "select *from itemtbl where itemPrice  between '" + lowervaluetxt.Text + "' and '" + highestvaluetxt.Text + "'";
                    displaydata(query);
 
                }
                
            }
            else if (searachcmb.Text == "ItemName")
            {

                string query = "select *from itemtbl where itemName='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "ItemType")
            {
                string query = "select *from itemtbl where itemType='" + searchvaluetxt.Text + "'";
                displaydata(query);
            }
            else if (searachcmb.Text == "ItemID")
            {
                string query = "select *from itemtbl where itemID='" + searchvaluetxt.Text + "'";
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
            itemgridview.DataSource = dt;
            con.Close();
            clear();
        }
    }
}
