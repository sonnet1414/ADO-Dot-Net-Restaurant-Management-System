using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace restaurant_managent_system
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

            homepanel.Visible = true;
            customerpanel.Visible = false;
            storagepanel.Visible = false;
            bookingpanel.Visible = false;
            orderpanel.Visible = false;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addbooking_Click(object sender, EventArgs e)
        {
            booknow ss = new booknow();
            ss.Show();

        }

        private void closewindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void bookinglist_Click(object sender, EventArgs e)
        {
            bookinglist ss = new bookinglist();
            ss.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            updatebooking ss = new updatebooking();
            ss.Show();
        }

        private void deletebooking_Click(object sender, EventArgs e)
        {
            deletebooking ss = new deletebooking();
            ss.Show();
        }

        
        private void itemlist_Click(object sender, EventArgs e)
        {
            itemlist ss = new itemlist();
            ss.Show();
        }

        private void itemmanagement_Click(object sender, EventArgs e)
        {
            storagemanagement ss = new storagemanagement();
            ss.Show();
        }

        private void customerlist_Click(object sender, EventArgs e)
        {
            customerlist ss = new customerlist();
            ss.Show();
        }

        private void managecustomer_Click(object sender, EventArgs e)
        {
            customermanagement ss = new customermanagement();
            ss.Show();
        }

        private void ordernow_Click(object sender, EventArgs e)
        {
            ordernow ss = new ordernow();
            ss.Show();
        }

        private void orderlist_Click(object sender, EventArgs e)
        {
            orderlist ss = new orderlist();
            ss.Show();
        }

        private void upateorder_Click(object sender, EventArgs e)
        {
            updateorder ss = new updateorder();
            ss.Show();
        }

        private void deleteorder_Click(object sender, EventArgs e)
        {
            deleteorder ss = new deleteorder();
            ss.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            homepanel.Visible = true;
            customerpanel.Visible = false;
            storagepanel.Visible = false;
            bookingpanel.Visible = false;
            orderpanel.Visible = false;
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            customerpanel.Visible = true;
            storagepanel.Visible = false;
            bookingpanel.Visible = false;
            orderpanel.Visible = false;
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            customerpanel.Visible = false;
            storagepanel.Visible = false;
            bookingpanel.Visible = true;
            orderpanel.Visible = false;
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            customerpanel.Visible = false;
            storagepanel.Visible = false;
            bookingpanel.Visible = false;
            orderpanel.Visible = true;
        }

        private void storagebtn_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            customerpanel.Visible = false;
            storagepanel.Visible = true;
            bookingpanel.Visible = false;
            orderpanel.Visible = false;
        }

        
    }
}
