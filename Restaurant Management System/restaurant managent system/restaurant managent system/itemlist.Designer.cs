namespace restaurant_managent_system
{
    partial class itemlist
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
            this.searchvaluetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searachcmb = new System.Windows.Forms.ComboBox();
            this.showtable = new System.Windows.Forms.Button();
            this.itemgridview = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet1 = new restaurant_managent_system.restaurantdbDataSet1();
            this.searchbtn = new System.Windows.Forms.Button();
            this.itemtblTableAdapter = new restaurant_managent_system.restaurantdbDataSet1TableAdapters.itemtblTableAdapter();
            this.lowervaluetxt = new System.Windows.Forms.TextBox();
            this.highestvaluetxt = new System.Windows.Forms.TextBox();
            this.limitlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchvaluetxt
            // 
            this.searchvaluetxt.Location = new System.Drawing.Point(242, 60);
            this.searchvaluetxt.Name = "searchvaluetxt";
            this.searchvaluetxt.Size = new System.Drawing.Size(295, 20);
            this.searchvaluetxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search By";
            // 
            // searachcmb
            // 
            this.searachcmb.FormattingEnabled = true;
            this.searachcmb.Items.AddRange(new object[] {
            "ItemID",
            "ItemName",
            "ItemType",
            "ItemPrice"});
            this.searachcmb.Location = new System.Drawing.Point(106, 59);
            this.searachcmb.Name = "searachcmb";
            this.searachcmb.Size = new System.Drawing.Size(121, 21);
            this.searachcmb.TabIndex = 10;
            this.searachcmb.SelectedIndexChanged += new System.EventHandler(this.searachcmb_SelectedIndexChanged);
            // 
            // showtable
            // 
            this.showtable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showtable.FlatAppearance.BorderSize = 0;
            this.showtable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.showtable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtable.Location = new System.Drawing.Point(-3, 378);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(709, 43);
            this.showtable.TabIndex = 9;
            this.showtable.Text = "Show Booking List";
            this.showtable.UseVisualStyleBackColor = false;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // itemgridview
            // 
            this.itemgridview.AutoGenerateColumns = false;
            this.itemgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn});
            this.itemgridview.DataSource = this.itemtblBindingSource;
            this.itemgridview.Location = new System.Drawing.Point(-3, 101);
            this.itemgridview.Name = "itemgridview";
            this.itemgridview.Size = new System.Drawing.Size(709, 270);
            this.itemgridview.TabIndex = 8;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "itemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "itemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // itemtblBindingSource
            // 
            this.itemtblBindingSource.DataMember = "itemtbl";
            this.itemtblBindingSource.DataSource = this.restaurantdbDataSet1;
            // 
            // restaurantdbDataSet1
            // 
            this.restaurantdbDataSet1.DataSetName = "restaurantdbDataSet1";
            this.restaurantdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(543, 60);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(138, 21);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // itemtblTableAdapter
            // 
            this.itemtblTableAdapter.ClearBeforeFill = true;
            // 
            // lowervaluetxt
            // 
            this.lowervaluetxt.Location = new System.Drawing.Point(242, 60);
            this.lowervaluetxt.Name = "lowervaluetxt";
            this.lowervaluetxt.Size = new System.Drawing.Size(139, 20);
            this.lowervaluetxt.TabIndex = 14;
            // 
            // highestvaluetxt
            // 
            this.highestvaluetxt.Location = new System.Drawing.Point(398, 60);
            this.highestvaluetxt.Name = "highestvaluetxt";
            this.highestvaluetxt.Size = new System.Drawing.Size(139, 20);
            this.highestvaluetxt.TabIndex = 15;
            // 
            // limitlbl
            // 
            this.limitlbl.AutoSize = true;
            this.limitlbl.Location = new System.Drawing.Point(385, 63);
            this.limitlbl.Name = "limitlbl";
            this.limitlbl.Size = new System.Drawing.Size(10, 13);
            this.limitlbl.TabIndex = 16;
            this.limitlbl.Text = "-";
            // 
            // itemlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 448);
            this.Controls.Add(this.limitlbl);
            this.Controls.Add(this.highestvaluetxt);
            this.Controls.Add(this.lowervaluetxt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchvaluetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searachcmb);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.itemgridview);
            this.Name = "itemlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemlist";
            this.Load += new System.EventHandler(this.itemlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchvaluetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searachcmb;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.DataGridView itemgridview;
        private System.Windows.Forms.Button searchbtn;
        private restaurantdbDataSet1 restaurantdbDataSet1;
        private System.Windows.Forms.BindingSource itemtblBindingSource;
        private restaurantdbDataSet1TableAdapters.itemtblTableAdapter itemtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox lowervaluetxt;
        private System.Windows.Forms.TextBox highestvaluetxt;
        private System.Windows.Forms.Label limitlbl;
    }
}