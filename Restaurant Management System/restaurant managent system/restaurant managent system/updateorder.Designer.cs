namespace restaurant_managent_system
{
    partial class updateorder
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
            this.showtablebtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deliverydatetxt = new System.Windows.Forms.DateTimePicker();
            this.totalitemtxt = new System.Windows.Forms.TextBox();
            this.ordergridview = new System.Windows.Forms.DataGridView();
            this.orderidtxt = new System.Windows.Forms.TextBox();
            this.restaurantdbDataSet5 = new restaurant_managent_system.restaurantdbDataSet5();
            this.ordertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordertblTableAdapter = new restaurant_managent_system.restaurantdbDataSet5TableAdapters.ordertblTableAdapter();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deliveryaddresstxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalquantitytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalpricetxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.showtablebtn.Location = new System.Drawing.Point(337, 380);
            this.showtablebtn.Name = "showtablebtn";
            this.showtablebtn.Size = new System.Drawing.Size(725, 43);
            this.showtablebtn.TabIndex = 39;
            this.showtablebtn.Text = "Show Table";
            this.showtablebtn.UseVisualStyleBackColor = false;
            this.showtablebtn.Click += new System.EventHandler(this.showtablebtn_Click);
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
            this.confirmbtn.Location = new System.Drawing.Point(9, 380);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(316, 43);
            this.confirmbtn.TabIndex = 38;
            this.confirmbtn.Text = "Update";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.totalpricetxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.totalquantitytxt);
            this.groupBox2.Controls.Add(this.deliveryaddresstxt);
            this.groupBox2.Controls.Add(this.orderidtxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.deliverydatetxt);
            this.groupBox2.Controls.Add(this.customeridtxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalitemtxt);
            this.groupBox2.Location = new System.Drawing.Point(9, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 347);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Order ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delivery Date:";
            // 
            // deliverydatetxt
            // 
            this.deliverydatetxt.Location = new System.Drawing.Point(13, 145);
            this.deliverydatetxt.Name = "deliverydatetxt";
            this.deliverydatetxt.Size = new System.Drawing.Size(275, 20);
            this.deliverydatetxt.TabIndex = 16;
            // 
            // totalitemtxt
            // 
            this.totalitemtxt.Location = new System.Drawing.Point(12, 296);
            this.totalitemtxt.Name = "totalitemtxt";
            this.totalitemtxt.Size = new System.Drawing.Size(65, 20);
            this.totalitemtxt.TabIndex = 23;
            // 
            // ordergridview
            // 
            this.ordergridview.AutoGenerateColumns = false;
            this.ordergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.totalItemDataGridViewTextBoxColumn,
            this.totalQuantityDataGridViewTextBoxColumn,
            this.totalBillDataGridViewTextBoxColumn});
            this.ordergridview.DataSource = this.ordertblBindingSource;
            this.ordergridview.Location = new System.Drawing.Point(337, 21);
            this.ordergridview.Name = "ordergridview";
            this.ordergridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordergridview.Size = new System.Drawing.Size(725, 341);
            this.ordergridview.TabIndex = 36;
            this.ordergridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ordergridview_MouseClick);
            // 
            // orderidtxt
            // 
            this.orderidtxt.Location = new System.Drawing.Point(13, 43);
            this.orderidtxt.Name = "orderidtxt";
            this.orderidtxt.Size = new System.Drawing.Size(275, 20);
            this.orderidtxt.TabIndex = 25;
            // 
            // restaurantdbDataSet5
            // 
            this.restaurantdbDataSet5.DataSetName = "restaurantdbDataSet5";
            this.restaurantdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordertblBindingSource
            // 
            this.ordertblBindingSource.DataMember = "ordertbl";
            this.ordertblBindingSource.DataSource = this.restaurantdbDataSet5;
            // 
            // ordertblTableAdapter
            // 
            this.ordertblTableAdapter.ClearBeforeFill = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "orderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "deliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "deliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            // 
            // totalItemDataGridViewTextBoxColumn
            // 
            this.totalItemDataGridViewTextBoxColumn.DataPropertyName = "totalItem";
            this.totalItemDataGridViewTextBoxColumn.HeaderText = "totalItem";
            this.totalItemDataGridViewTextBoxColumn.Name = "totalItemDataGridViewTextBoxColumn";
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            this.totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "totalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.HeaderText = "totalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            // 
            // totalBillDataGridViewTextBoxColumn
            // 
            this.totalBillDataGridViewTextBoxColumn.DataPropertyName = "totalBill";
            this.totalBillDataGridViewTextBoxColumn.HeaderText = "totalBill";
            this.totalBillDataGridViewTextBoxColumn.Name = "totalBillDataGridViewTextBoxColumn";
            // 
            // customeridtxt
            // 
            this.customeridtxt.Location = new System.Drawing.Point(13, 95);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.Size = new System.Drawing.Size(275, 20);
            this.customeridtxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Customer ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Delivery Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Total Item";
            // 
            // deliveryaddresstxt
            // 
            this.deliveryaddresstxt.Location = new System.Drawing.Point(13, 203);
            this.deliveryaddresstxt.Name = "deliveryaddresstxt";
            this.deliveryaddresstxt.Size = new System.Drawing.Size(275, 63);
            this.deliveryaddresstxt.TabIndex = 44;
            this.deliveryaddresstxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Total Quantity";
            // 
            // totalquantitytxt
            // 
            this.totalquantitytxt.Location = new System.Drawing.Point(123, 296);
            this.totalquantitytxt.Name = "totalquantitytxt";
            this.totalquantitytxt.Size = new System.Drawing.Size(65, 20);
            this.totalquantitytxt.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Total Price";
            // 
            // totalpricetxt
            // 
            this.totalpricetxt.Location = new System.Drawing.Point(233, 296);
            this.totalpricetxt.Name = "totalpricetxt";
            this.totalpricetxt.Size = new System.Drawing.Size(65, 20);
            this.totalpricetxt.TabIndex = 47;
            // 
            // updateorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.showtablebtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ordergridview);
            this.Name = "updateorder";
            this.Text = "updateorder";
            this.Load += new System.EventHandler(this.updateorder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showtablebtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker deliverydatetxt;
        private System.Windows.Forms.TextBox totalitemtxt;
        private System.Windows.Forms.DataGridView ordergridview;
        private System.Windows.Forms.TextBox orderidtxt;
        private restaurantdbDataSet5 restaurantdbDataSet5;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private restaurantdbDataSet5TableAdapters.ordertblTableAdapter ordertblTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalpricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalquantitytxt;
        private System.Windows.Forms.RichTextBox deliveryaddresstxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customeridtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
    }
}