namespace restaurant_managent_system
{
    partial class deletebooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.bookinggridview = new System.Windows.Forms.DataGridView();
            this.showtablebtn = new System.Windows.Forms.Button();
            this.bookingidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.restaurantdbDataSet = new restaurant_managent_system.restaurantdbDataSet();
            this.bookingtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingtblTableAdapter = new restaurant_managent_system.restaurantdbDataSetTableAdapters.bookingtblTableAdapter();
            this.bookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinggridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 27);
            this.panel1.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.Image = global::restaurant_managent_system.Properties.Resources.close_red;
            this.closebtn.Location = new System.Drawing.Point(696, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(27, 27);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 1;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
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
            this.bookinggridview.Location = new System.Drawing.Point(0, 106);
            this.bookinggridview.Name = "bookinggridview";
            this.bookinggridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookinggridview.Size = new System.Drawing.Size(723, 285);
            this.bookinggridview.TabIndex = 1;
            this.bookinggridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookinggridview_MouseClick);
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
            this.showtablebtn.Location = new System.Drawing.Point(0, 397);
            this.showtablebtn.Name = "showtablebtn";
            this.showtablebtn.Size = new System.Drawing.Size(723, 43);
            this.showtablebtn.TabIndex = 36;
            this.showtablebtn.Text = "Show Table";
            this.showtablebtn.UseVisualStyleBackColor = false;
            this.showtablebtn.Click += new System.EventHandler(this.showtablebtn_Click);
            // 
            // bookingidtxt
            // 
            this.bookingidtxt.Location = new System.Drawing.Point(121, 74);
            this.bookingidtxt.Name = "bookingidtxt";
            this.bookingidtxt.Size = new System.Drawing.Size(152, 20);
            this.bookingidtxt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Booking ID :";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(288, 60);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(103, 33);
            this.deletebtn.TabIndex = 39;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // restaurantdbDataSet
            // 
            this.restaurantdbDataSet.DataSetName = "restaurantdbDataSet";
            this.restaurantdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingtblBindingSource
            // 
            this.bookingtblBindingSource.DataMember = "bookingtbl";
            this.bookingtblBindingSource.DataSource = this.restaurantdbDataSet;
            // 
            // bookingtblTableAdapter
            // 
            this.bookingtblTableAdapter.ClearBeforeFill = true;
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
            // deletebooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.bookingidtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showtablebtn);
            this.Controls.Add(this.bookinggridview);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deletebooking";
            this.Text = "deletebooking";
            this.Load += new System.EventHandler(this.deletebooking_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinggridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.DataGridView bookinggridview;
        private System.Windows.Forms.Button showtablebtn;
        private System.Windows.Forms.TextBox bookingidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private restaurantdbDataSet restaurantdbDataSet;
        private System.Windows.Forms.BindingSource bookingtblBindingSource;
        private restaurantdbDataSetTableAdapters.bookingtblTableAdapter bookingtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfTableDataGridViewTextBoxColumn;
    }
}