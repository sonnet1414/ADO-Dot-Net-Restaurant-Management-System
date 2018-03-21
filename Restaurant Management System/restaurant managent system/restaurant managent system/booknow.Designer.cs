namespace restaurant_managent_system
{
    partial class booknow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fetchbtn = new System.Windows.Forms.Button();
            this.cusidtxt = new System.Windows.Forms.TextBox();
            this.cusidlbl = new System.Windows.Forms.Label();
            this.customerchkbox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingdate = new System.Windows.Forms.DateTimePicker();
            this.tabletxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guesttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.initialtcb = new System.Windows.Forms.ComboBox();
            this.p2tcb = new System.Windows.Forms.ComboBox();
            this.p1tcb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finaltcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.caddressrtxt = new System.Windows.Forms.RichTextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cphonetxt = new System.Windows.Forms.TextBox();
            this.cemailtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::restaurant_managent_system.Properties.Resources.close_red;
            this.pictureBox1.Location = new System.Drawing.Point(612, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fetchbtn);
            this.panel2.Controls.Add(this.cusidtxt);
            this.panel2.Controls.Add(this.cusidlbl);
            this.panel2.Controls.Add(this.customerchkbox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.confirmbtn);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 513);
            this.panel2.TabIndex = 8;
            // 
            // fetchbtn
            // 
            this.fetchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.fetchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fetchbtn.FlatAppearance.BorderSize = 0;
            this.fetchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.fetchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.fetchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchbtn.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchbtn.Location = new System.Drawing.Point(344, 33);
            this.fetchbtn.Name = "fetchbtn";
            this.fetchbtn.Size = new System.Drawing.Size(294, 27);
            this.fetchbtn.TabIndex = 26;
            this.fetchbtn.Text = "Fetch";
            this.fetchbtn.UseVisualStyleBackColor = false;
            this.fetchbtn.Click += new System.EventHandler(this.fetchbtn_Click);
            // 
            // cusidtxt
            // 
            this.cusidtxt.Location = new System.Drawing.Point(124, 33);
            this.cusidtxt.Multiline = true;
            this.cusidtxt.Name = "cusidtxt";
            this.cusidtxt.Size = new System.Drawing.Size(203, 27);
            this.cusidtxt.TabIndex = 25;
            // 
            // cusidlbl
            // 
            this.cusidlbl.AutoSize = true;
            this.cusidlbl.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusidlbl.Location = new System.Drawing.Point(8, 36);
            this.cusidlbl.Name = "cusidlbl";
            this.cusidlbl.Size = new System.Drawing.Size(110, 24);
            this.cusidlbl.TabIndex = 16;
            this.cusidlbl.Text = "Customer ID:";
            // 
            // customerchkbox
            // 
            this.customerchkbox.AutoSize = true;
            this.customerchkbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.customerchkbox.Location = new System.Drawing.Point(213, 11);
            this.customerchkbox.Name = "customerchkbox";
            this.customerchkbox.Size = new System.Drawing.Size(15, 14);
            this.customerchkbox.TabIndex = 27;
            this.customerchkbox.UseVisualStyleBackColor = true;
            this.customerchkbox.CheckedChanged += new System.EventHandler(this.customerchkbox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "For Registered Customer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bookingdate);
            this.groupBox2.Controls.Add(this.tabletxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.guesttxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.initialtcb);
            this.groupBox2.Controls.Add(this.p2tcb);
            this.groupBox2.Controls.Add(this.p1tcb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.finaltcb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(344, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 330);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // bookingdate
            // 
            this.bookingdate.Location = new System.Drawing.Point(63, 19);
            this.bookingdate.Name = "bookingdate";
            this.bookingdate.Size = new System.Drawing.Size(200, 20);
            this.bookingdate.TabIndex = 16;
            // 
            // tabletxt
            // 
            this.tabletxt.Location = new System.Drawing.Point(22, 233);
            this.tabletxt.Name = "tabletxt";
            this.tabletxt.Size = new System.Drawing.Size(152, 20);
            this.tabletxt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // guesttxt
            // 
            this.guesttxt.Location = new System.Drawing.Point(22, 163);
            this.guesttxt.Name = "guesttxt";
            this.guesttxt.Size = new System.Drawing.Size(152, 20);
            this.guesttxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "No of Table:";
            // 
            // initialtcb
            // 
            this.initialtcb.FormattingEnabled = true;
            this.initialtcb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.initialtcb.Location = new System.Drawing.Point(66, 69);
            this.initialtcb.Name = "initialtcb";
            this.initialtcb.Size = new System.Drawing.Size(41, 21);
            this.initialtcb.TabIndex = 18;
            // 
            // p2tcb
            // 
            this.p2tcb.FormattingEnabled = true;
            this.p2tcb.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.p2tcb.Location = new System.Drawing.Point(222, 69);
            this.p2tcb.Name = "p2tcb";
            this.p2tcb.Size = new System.Drawing.Size(48, 21);
            this.p2tcb.TabIndex = 21;
            // 
            // p1tcb
            // 
            this.p1tcb.FormattingEnabled = true;
            this.p1tcb.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.p1tcb.Location = new System.Drawing.Point(107, 69);
            this.p1tcb.Name = "p1tcb";
            this.p1tcb.Size = new System.Drawing.Size(40, 21);
            this.p1tcb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "No of Guest:";
            // 
            // finaltcb
            // 
            this.finaltcb.FormattingEnabled = true;
            this.finaltcb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.finaltcb.Location = new System.Drawing.Point(180, 69);
            this.finaltcb.Name = "finaltcb";
            this.finaltcb.Size = new System.Drawing.Size(42, 21);
            this.finaltcb.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.caddressrtxt);
            this.groupBox1.Controls.Add(this.cnametxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cphonetxt);
            this.groupBox1.Controls.Add(this.cemailtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 331);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer Name:";
            // 
            // caddressrtxt
            // 
            this.caddressrtxt.Location = new System.Drawing.Point(19, 238);
            this.caddressrtxt.Name = "caddressrtxt";
            this.caddressrtxt.Size = new System.Drawing.Size(292, 44);
            this.caddressrtxt.TabIndex = 30;
            this.caddressrtxt.Text = "";
            // 
            // cnametxt
            // 
            this.cnametxt.Location = new System.Drawing.Point(19, 43);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(292, 20);
            this.cnametxt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Customer Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Email:";
            // 
            // cphonetxt
            // 
            this.cphonetxt.Location = new System.Drawing.Point(19, 168);
            this.cphonetxt.Name = "cphonetxt";
            this.cphonetxt.Size = new System.Drawing.Size(292, 20);
            this.cphonetxt.TabIndex = 28;
            // 
            // cemailtxt
            // 
            this.cemailtxt.Location = new System.Drawing.Point(19, 102);
            this.cemailtxt.Name = "cemailtxt";
            this.cemailtxt.Size = new System.Drawing.Size(292, 20);
            this.cemailtxt.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Customer Phone:";
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.confirmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmbtn.FlatAppearance.BorderSize = 0;
            this.confirmbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.confirmbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(19, 434);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(587, 43);
            this.confirmbtn.TabIndex = 17;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(641, 513);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 335;
            this.lineShape1.X2 = 335;
            this.lineShape1.Y1 = 85;
            this.lineShape1.Y2 = 409;
            // 
            // booknow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "booknow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "booknow";
            this.Load += new System.EventHandler(this.booknow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox p2tcb;
        private System.Windows.Forms.ComboBox finaltcb;
        private System.Windows.Forms.ComboBox p1tcb;
        private System.Windows.Forms.ComboBox initialtcb;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.DateTimePicker bookingdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox tabletxt;
        private System.Windows.Forms.TextBox guesttxt;
        private System.Windows.Forms.TextBox cphonetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cemailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox caddressrtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.CheckBox customerchkbox;
        private System.Windows.Forms.Button fetchbtn;
        private System.Windows.Forms.TextBox cusidtxt;
        private System.Windows.Forms.Label cusidlbl;
    }
}