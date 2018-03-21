namespace restaurant_managent_system
{
    partial class deleteorder
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.orderidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showtablebtn = new System.Windows.Forms.Button();
            this.ordergridview = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.deletebtn.Location = new System.Drawing.Point(280, 32);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(103, 33);
            this.deletebtn.TabIndex = 44;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // orderidtxt
            // 
            this.orderidtxt.Location = new System.Drawing.Point(113, 46);
            this.orderidtxt.Name = "orderidtxt";
            this.orderidtxt.Size = new System.Drawing.Size(152, 20);
            this.orderidtxt.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "order ID :";
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
            this.showtablebtn.Location = new System.Drawing.Point(-8, 369);
            this.showtablebtn.Name = "showtablebtn";
            this.showtablebtn.Size = new System.Drawing.Size(723, 43);
            this.showtablebtn.TabIndex = 41;
            this.showtablebtn.Text = "Show Table";
            this.showtablebtn.UseVisualStyleBackColor = false;
            this.showtablebtn.Click += new System.EventHandler(this.showtablebtn_Click);
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
            this.ordergridview.Location = new System.Drawing.Point(-8, 78);
            this.ordergridview.Name = "ordergridview";
            this.ordergridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordergridview.Size = new System.Drawing.Size(723, 285);
            this.ordergridview.TabIndex = 40;
            this.ordergridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ordergridview_MouseClick);
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
            // deleteorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 444);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.orderidtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showtablebtn);
            this.Controls.Add(this.ordergridview);
            this.Name = "deleteorder";
            this.Text = "deleteorder";
            this.Load += new System.EventHandler(this.deleteorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox orderidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showtablebtn;
        private System.Windows.Forms.DataGridView ordergridview;
        private restaurantdbDataSet5 restaurantdbDataSet5;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private restaurantdbDataSet5TableAdapters.ordertblTableAdapter ordertblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
    }
}