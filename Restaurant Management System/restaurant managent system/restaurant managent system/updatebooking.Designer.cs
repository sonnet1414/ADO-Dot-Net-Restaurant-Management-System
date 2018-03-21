namespace restaurant_managent_system
{
    partial class updatebooking
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
            this.components = new System.ComponentModel.Container();
            this.bookinggridview = new System.Windows.Forms.DataGridView();
            this.bookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet = new restaurant_managent_system.restaurantdbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookingidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingdatetxt = new System.Windows.Forms.DateTimePicker();
            this.tabletxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guesttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.showtablebtn = new System.Windows.Forms.Button();
            this.bookingtblTableAdapter = new restaurant_managent_system.restaurantdbDataSetTableAdapters.bookingtblTableAdapter();
            this.p2tcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finaltcb = new System.Windows.Forms.ComboBox();
            this.initialtcb = new System.Windows.Forms.ComboBox();
            this.p1tcb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookinggridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookinggridview
            // 
            this.bookinggridview.AutoGenerateColumns = false;
            this.bookinggridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinggridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIdDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingStartTimeDataGridViewTextBoxColumn,
            this.bookingEndTimeDataGridViewTextBoxColumn,
            this.noOfGuestDataGridViewTextBoxColumn,
            this.noOfTableDataGridViewTextBoxColumn});
            this.bookinggridview.DataSource = this.bookingtblBindingSource;
            this.bookinggridview.Location = new System.Drawing.Point(312, 58);
            this.bookinggridview.Name = "bookinggridview";
            this.bookinggridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookinggridview.Size = new System.Drawing.Size(529, 272);
            this.bookinggridview.TabIndex = 0;
            this.bookinggridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookinggridview_MouseClick);
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            this.bookingIdDataGridViewTextBoxColumn.DataPropertyName = "bookingId";
            this.bookingIdDataGridViewTextBoxColumn.HeaderText = "bookingId";
            this.bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "bookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "bookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // bookingStartTimeDataGridViewTextBoxColumn
            // 
            this.bookingStartTimeDataGridViewTextBoxColumn.DataPropertyName = "bookingStartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.HeaderText = "bookingStartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.Name = "bookingStartTimeDataGridViewTextBoxColumn";
            // 
            // bookingEndTimeDataGridViewTextBoxColumn
            // 
            this.bookingEndTimeDataGridViewTextBoxColumn.DataPropertyName = "bookingEndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.HeaderText = "bookingEndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.Name = "bookingEndTimeDataGridViewTextBoxColumn";
            // 
            // noOfGuestDataGridViewTextBoxColumn
            // 
            this.noOfGuestDataGridViewTextBoxColumn.DataPropertyName = "NoOfGuest";
            this.noOfGuestDataGridViewTextBoxColumn.HeaderText = "NoOfGuest";
            this.noOfGuestDataGridViewTextBoxColumn.Name = "noOfGuestDataGridViewTextBoxColumn";
            // 
            // noOfTableDataGridViewTextBoxColumn
            // 
            this.noOfTableDataGridViewTextBoxColumn.DataPropertyName = "NoOfTable";
            this.noOfTableDataGridViewTextBoxColumn.HeaderText = "NoOfTable";
            this.noOfTableDataGridViewTextBoxColumn.Name = "noOfTableDataGridViewTextBoxColumn";
            // 
            // bookingtblBindingSource
            // 
            this.bookingtblBindingSource.DataMember = "bookingtbl";
            this.bookingtblBindingSource.DataSource = this.restaurantdbDataSet;
            // 
            // restaurantdbDataSet
            // 
            this.restaurantdbDataSet.DataSetName = "restaurantdbDataSet";
            this.restaurantdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 25);
            this.panel1.TabIndex = 1;
            // 
            // closebtn
            // 
            this.closebtn.Image = global::restaurant_managent_system.Properties.Resources.close_red;
            this.closebtn.Location = new System.Drawing.Point(816, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(25, 25);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 2;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookingidtxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bookingdatetxt);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 278);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Details:";
            // 
            // bookingidtxt
            // 
            this.bookingidtxt.Location = new System.Drawing.Point(118, 38);
            this.bookingidtxt.Name = "bookingidtxt";
            this.bookingidtxt.Size = new System.Drawing.Size(152, 20);
            this.bookingidtxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Booking ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // bookingdatetxt
            // 
            this.bookingdatetxt.Location = new System.Drawing.Point(66, 76);
            this.bookingdatetxt.Name = "bookingdatetxt";
            this.bookingdatetxt.Size = new System.Drawing.Size(204, 20);
            this.bookingdatetxt.TabIndex = 16;
            // 
            // tabletxt
            // 
            this.tabletxt.Location = new System.Drawing.Point(22, 252);
            this.tabletxt.Name = "tabletxt";
            this.tabletxt.Size = new System.Drawing.Size(152, 20);
            this.tabletxt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // guesttxt
            // 
            this.guesttxt.Location = new System.Drawing.Point(22, 193);
            this.guesttxt.Name = "guesttxt";
            this.guesttxt.Size = new System.Drawing.Size(152, 20);
            this.guesttxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "No of Table:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "No of Guest:";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(12, 336);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(294, 43);
            this.updatebtn.TabIndex = 34;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // showtablebtn
            // 
            this.showtablebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.showtablebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showtablebtn.FlatAppearance.BorderSize = 0;
            this.showtablebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.showtablebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.showtablebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtablebtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtablebtn.Location = new System.Drawing.Point(312, 336);
            this.showtablebtn.Name = "showtablebtn";
            this.showtablebtn.Size = new System.Drawing.Size(529, 43);
            this.showtablebtn.TabIndex = 35;
            this.showtablebtn.Text = "Show Table";
            this.showtablebtn.UseVisualStyleBackColor = false;
            this.showtablebtn.Click += new System.EventHandler(this.showtablebtn_Click);
            // 
            // bookingtblTableAdapter
            // 
            this.bookingtblTableAdapter.ClearBeforeFill = true;
            // 
            // p2tcb
            // 
            this.p2tcb.FormattingEnabled = true;
            this.p2tcb.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.p2tcb.Location = new System.Drawing.Point(222, 116);
            this.p2tcb.Name = "p2tcb";
            this.p2tcb.Size = new System.Drawing.Size(48, 21);
            this.p2tcb.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To";
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
            this.finaltcb.Location = new System.Drawing.Point(180, 116);
            this.finaltcb.Name = "finaltcb";
            this.finaltcb.Size = new System.Drawing.Size(42, 21);
            this.finaltcb.TabIndex = 20;
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
            this.initialtcb.Location = new System.Drawing.Point(66, 116);
            this.initialtcb.Name = "initialtcb";
            this.initialtcb.Size = new System.Drawing.Size(41, 21);
            this.initialtcb.TabIndex = 18;
            // 
            // p1tcb
            // 
            this.p1tcb.FormattingEnabled = true;
            this.p1tcb.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.p1tcb.Location = new System.Drawing.Point(104, 116);
            this.p1tcb.Name = "p1tcb";
            this.p1tcb.Size = new System.Drawing.Size(40, 21);
            this.p1tcb.TabIndex = 19;
            // 
            // updatebooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 391);
            this.Controls.Add(this.showtablebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookinggridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatebooking";
            this.Text = "updatebooking";
            this.Load += new System.EventHandler(this.updatebooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookinggridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookinggridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bookingdatetxt;
        private System.Windows.Forms.TextBox tabletxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guesttxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button showtablebtn;
        private System.Windows.Forms.TextBox bookingidtxt;
        private System.Windows.Forms.Label label1;
        private restaurantdbDataSet restaurantdbDataSet;
        private System.Windows.Forms.BindingSource bookingtblBindingSource;
        private restaurantdbDataSetTableAdapters.bookingtblTableAdapter bookingtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox initialtcb;
        private System.Windows.Forms.ComboBox p2tcb;
        private System.Windows.Forms.ComboBox p1tcb;
        private System.Windows.Forms.ComboBox finaltcb;
        private System.Windows.Forms.Label label7;
    }
}