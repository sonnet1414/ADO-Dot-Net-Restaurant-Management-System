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
    public partial class ordernow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONNET;Initial Catalog=restaurantdb;Persist Security Info=True;User ID=sa;Password=ewu");
        public ordernow()
        {
            InitializeComponent();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {

        }

        private void ordernow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet5.ordertbl' table. You can move, or remove it, as needed.
            this.ordertblTableAdapter.Fill(this.restaurantdbDataSet5.ordertbl);
            // TODO: This line of code loads data into the 'restaurantdbDataSet4.carttbl' table. You can move, or remove it, as needed.
            this.carttblTableAdapter1.Fill(this.restaurantdbDataSet4.carttbl);
            // TODO: This line of code loads data into the 'restaurantdbDataSet3.carttbl' table. You can move, or remove it, as needed.
            this.carttblTableAdapter.Fill(this.restaurantdbDataSet3.carttbl);
            // TODO: This line of code loads data into the 'restaurantdbDataSet1.itemtbl' table. You can move, or remove it, as needed.
            this.itemtblTableAdapter.Fill(this.restaurantdbDataSet1.itemtbl);

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void generateorderidbtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.ToString("yyyyMMddHHmmss");
            s = "O" + s;
            orderidtxt.Text = s;
        }

        private void addcartbtn_Click(object sender, EventArgs e)
        {
            if(orderidtxt.Text=="")
            {
                MessageBox.Show("Generate Order ID");
            }
            else if (itemidtxt.Text==""||itemnametxt.Text == "" || itempricetxt.Text == "")
            {
                MessageBox.Show("Click Item from Item List");
            }
            else if (itemquantitytxt.Text == "")
            {
                MessageBox.Show("Input Quantity");
            }
            else
            {
                con.Open();
                string query = "insert into carttbl (itemId,itemName,ItemPrice,itemQuantity,totalPrice)values(@itemId,@itemName,@ItemPrice,@itemQuantity,@totalPrice)";
                SqlCommand bcmd = new SqlCommand(query, con);
                bcmd.Parameters.Add("@itemId", itemidtxt.Text);
                bcmd.Parameters.Add("@itemName", itemnametxt.Text);
                bcmd.Parameters.Add("@ItemPrice", Convert.ToInt32(itempricetxt.Text));
                bcmd.Parameters.Add("@ItemQuantity", Convert.ToInt32(itemquantitytxt.Text));
                string total = (Convert.ToInt32(itemquantitytxt.Text) * Convert.ToInt32(itempricetxt.Text)).ToString();
                bcmd.Parameters.Add("@totalPrice", Convert.ToInt32(total));
                bcmd.ExecuteNonQuery();
                con.Close();
                clearitemdata();
                query = "select *from carttbl";
                displaycartdata(query);
            }

        }
        public void insertdata()
        {
            
        }
        public void clearitemdata()
        {
            itemidtxt.Text = "";
            itemnametxt.Text = "";
            itemtypetxt.Text = "";
            itempricetxt.Text = "";
            itemquantitytxt.Text = "";
        }

        private void itemgridview_MouseClick(object sender, MouseEventArgs e)
        {
            itemidtxt.Text = itemgridview.SelectedRows[0].Cells[0].Value.ToString();
            itemnametxt.Text = itemgridview.SelectedRows[0].Cells[1].Value.ToString();
            itemtypetxt.Text = itemgridview.SelectedRows[0].Cells[2].Value.ToString();
            itempricetxt.Text = itemgridview.SelectedRows[0].Cells[3].Value.ToString();
        }
        public void displaycartdata(string query)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cartgridview.DataSource = dt;
            con.Close();
        }

        private void cartgridview_MouseClick(object sender, MouseEventArgs e)
        {
            citemidtxt.Text = cartgridview.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void cartremovebtn_Click(object sender, EventArgs e)
        {
            if (citemidtxt.Text == "")
            {
                MessageBox.Show("Select Item from Cart");
            }
            else
            {
                deletecartdata();
            }

        }
        public void deletecartdata()
        {
            con.Open();
            string query = "delete from carttbl where itemId='" + citemidtxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            query = "select *from carttbl";
            displaycartdata(query);
            clearcartdata();
        }
        public void clearcartdata()
        {
            citemidtxt.Text = "";
            totalitemtxt.Text = "";
            totalquantitytxt.Text = "";
            totalbilltxt.Text = "";
        }

        private void grandtotalbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select count(distinct itemId) as totalitem from carttbl";
            SqlCommand icmd = new SqlCommand(query, con);
            SqlDataReader idr = icmd.ExecuteReader();
            if (idr.Read())
            {
                totalitemtxt.Text = (idr["totalitem"].ToString());

            }
            else
            {
                MessageBox.Show("Data not Found");
            }
            con.Close();



            con.Open();
            query = "select sum(itemQuantity) as totalquantity from carttbl";
            SqlCommand qcmd = new SqlCommand(query, con);
            SqlDataReader qdr = qcmd.ExecuteReader();
            if (qdr.Read())
            {
                totalquantitytxt.Text = (qdr["totalquantity"].ToString());

            }
            else
            {
                MessageBox.Show("Data not Found");
            }
            con.Close();


            con.Open();
            query = "select sum(totalPrice) as totalbill from carttbl";
            SqlCommand pcmd = new SqlCommand(query, con);
            SqlDataReader pdr = pcmd.ExecuteReader();
            if (pdr.Read())
            {
                totalbilltxt.Text = (pdr["totalbill"].ToString());

            }
            else
            {
                MessageBox.Show("Data not Found");
            }
            con.Close();
            
        }

        private void customerloadbtn_Click(object sender, EventArgs e)
        {
            if (customeridtxt.Text=="")
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                con.Open();
                string query = "select *from customertbl where customerId='" + customeridtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    customernametxt.Text = (dr["customerName"].ToString());
                    customeremailtxt.Text = (dr["customerEmail"].ToString());
                    customerphonetxt.Text = (dr["customerPhoneNo"].ToString());
                    customeraddresstxt.Text = (dr["customerAddress"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not Found");
                }
                con.Close();
            }
        }

        private void daddresschk_CheckedChanged(object sender, EventArgs e)
        {
            if (daddresschk.Checked)
            {
                if (customeraddresstxt.Text == "")
                {
                    MessageBox.Show("Load Customer Information First");
                }
                else
                {
                    daddresstxt.Text = customeraddresstxt.Text;
                }
                
            }
            else
            {
                daddresstxt.Text = "";
 
            }
        }

        private void confirmorderbtn_Click(object sender, EventArgs e)
        {
            if (orderidtxt.Text == "" || customeridtxt.Text=="")
            {
                MessageBox.Show("Enter Customer ID or Order ID");
            }
            else if(daddresstxt.Text==""||dDatetxt.Text=="")
            {
                MessageBox.Show("check Delivery Details");
            }
            else if (totalitemtxt.Text == "" || totalquantitytxt.Text == "" || totalbilltxt.Text == "")
            {
                MessageBox.Show("Press Grand Total Button");
            }
            else
            {
                insertorderdata();

                con.Open();
                string query = "delete from carttbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                query = "select *from carttbl";
                displaycartdata(query);

                clearalldata();
            }

        }
        public void clearalldata()
        {
            clearcartdata();
            clearitemdata();
            orderidtxt.Text = "";
            customeridtxt.Text = "";
            customernametxt.Text = "";
            customeremailtxt.Text = "";
            customerphonetxt.Text = "";
            customeraddresstxt.Text = "";
            daddresstxt.Text = "";
            daddresschk.Checked = false;

        }
        public void insertorderdata()
        {
            con.Open();
            string query = "insert into ordertbl (orderId,customerId,deliveryDate,deliveryAddress,totalItem,totalQuantity,totalBill)values(@orderId,@customerId,@deliveryDate,@deliveryAddress,@totalItem,@totalQuantity,@totalBill)";
            SqlCommand bcmd = new SqlCommand(query, con);
            bcmd.Parameters.Add("@orderId", orderidtxt.Text);
            bcmd.Parameters.Add("@customerId", customeridtxt.Text);
            bcmd.Parameters.Add("@deliveryDate", dDatetxt.Text);
            bcmd.Parameters.Add("@deliveryAddress", daddresstxt.Text);
            bcmd.Parameters.Add("@totalItem", Convert.ToInt32(totalitemtxt.Text));
            bcmd.Parameters.Add("@totalQuantity", Convert.ToInt32(totalquantitytxt.Text));
            bcmd.Parameters.Add("@totalBill", Convert.ToInt32(totalbilltxt.Text));
            bcmd.ExecuteNonQuery();
            con.Close();
            query = "select *from ordertbl";
            displayorderdata(query);
        }
        public void displayorderdata(string query)
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from carttbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();

            query = "select *from carttbl";
            displaycartdata(query);
        }

        private void itemsearchcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select *from itemtbl where itemType='"+itemsearchcmb.Text+"'";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            itemgridview.DataSource = dt;
            con.Close();
        }

        private void allsearchchk_CheckedChanged(object sender, EventArgs e)
        {
            if (allsearchchk.Checked)
            {
                itemsearchcmb.Visible = false;
                con.Open();
                string query = "select *from itemtbl";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                itemgridview.DataSource = dt;
                con.Close();
            }
            else
            {
                itemsearchcmb.Visible = true ;
            }
        }
        
    }
}
