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
    public partial class storagemanagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        
        public storagemanagement()
        {
            InitializeComponent();
        }
        private void storagemanagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet1.itemtbl' table. You can move, or remove it, as needed.
            this.itemtblTableAdapter.Fill(this.restaurantdbDataSet1.itemtbl);

        }

        private void showtable_Click(object sender, EventArgs e)
        {
            string query = "select *from itemtbl";
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
            itemlistgb.DataSource = dt;
            con.Close();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (itemidtxt.Text == "" || itemnametxt.Text == "" || itemtypetxt.Text == "" || itempricetxt.Text == "")
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
            if (itemidtxt.Text == "" || itemnametxt.Text == "" || itemtypetxt.Text == "" || itempricetxt.Text == "")
            {
                MessageBox.Show("Select Row from Item Table");
            }
            else
            {
                updatedata();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (itemidtxt.Text == "")
            {
                MessageBox.Show("Select Row from Item Table");
            }
            else
            {
                deletedata();
            }
        }

        

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void itemlistgb_MouseClick(object sender, MouseEventArgs e)
        {
            itemidtxt.Text = itemlistgb.SelectedRows[0].Cells[0].Value.ToString();
            itemnametxt.Text = itemlistgb.SelectedRows[0].Cells[1].Value.ToString();
            itemtypetxt.Text = itemlistgb.SelectedRows[0].Cells[2].Value.ToString();
            itempricetxt.Text = itemlistgb.SelectedRows[0].Cells[3].Value.ToString();
        }
        public void insertdata()
        {
            con.Open();
            string query = "insert into itemtbl (itemId,itemName,itemType,ItemPrice)values(@itemId,@itemName,@itemType,@ItemPrice)";
            SqlCommand bcmd = new SqlCommand(query, con);
            bcmd.Parameters.Add("@itemId", itemidtxt.Text);
            bcmd.Parameters.Add("@itemName", itemnametxt.Text);
            bcmd.Parameters.Add("@itemType", itemtypetxt.Text);
            bcmd.Parameters.Add("@ItemPrice", Convert.ToInt32(itempricetxt.Text));
            bcmd.ExecuteNonQuery();
            con.Close();
            query = "select *from itemtbl";
            displaydata(query);
            clear();
        }
        public void updatedata()
        {
            con.Open();
            string query = "update itemtbl set itemName='" + itemnametxt.Text + "',itemType='" + itemtypetxt.Text + "',itemPrice='" + Convert.ToInt32(itempricetxt.Text) + "' where itemId='" + itemidtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            query = "select *from itemtbl";
            displaydata(query);
            clear();
        }
        public void deletedata()
        {
            con.Open();
            string query = "delete from itemtbl where itemId='" + itemidtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            query = "select *from itemtbl";
            displaydata(query);
            clear();
        }

        private void generateitemid_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.ToString("yyyyMMddHHmmss");
            s = "I" + s;
            itemidtxt.Text = s;
        }
        public void clear()
        {
            itemidtxt.Text = "";
            itemnametxt.Text = "";
            itemtypetxt.Text = "";
            itempricetxt.Text = "";
        }
  
    }
}
