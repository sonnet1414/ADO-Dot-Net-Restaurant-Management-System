namespace restaurant_managent_system
{
    partial class customermanagement
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
            this.updatebtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customeraddresstxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerphonenotxt = new System.Windows.Forms.TextBox();
            this.customeremailtxt = new System.Windows.Forms.TextBox();
            this.customernametxt = new System.Windows.Forms.TextBox();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showtable = new System.Windows.Forms.Button();
            this.customergridview = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet2 = new restaurant_managent_system.restaurantdbDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customertblTableAdapter = new restaurant_managent_system.restaurantdbDataSet2TableAdapters.customertblTableAdapter();
            this.generatecusID = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(204, 350);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(93, 44);
            this.deletebtn.TabIndex = 19;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Location = new System.Drawing.Point(105, 350);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(93, 44);
            this.updatebtn.TabIndex = 20;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.insertbtn.FlatAppearance.BorderSize = 0;
            this.insertbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.insertbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbtn.Location = new System.Drawing.Point(6, 350);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(93, 44);
            this.insertbtn.TabIndex = 18;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customeraddresstxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.customerphonenotxt);
            this.groupBox2.Controls.Add(this.customeremailtxt);
            this.groupBox2.Controls.Add(this.customernametxt);
            this.groupBox2.Controls.Add(this.customeridtxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 279);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // customeraddresstxt
            // 
            this.customeraddresstxt.Location = new System.Drawing.Point(27, 239);
            this.customeraddresstxt.Name = "customeraddresstxt";
            this.customeraddresstxt.Size = new System.Drawing.Size(264, 33);
            this.customeraddresstxt.TabIndex = 9;
            this.customeraddresstxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Address";
            // 
            // customerphonenotxt
            // 
            this.customerphonenotxt.Location = new System.Drawing.Point(27, 183);
            this.customerphonenotxt.Name = "customerphonenotxt";
            this.customerphonenotxt.Size = new System.Drawing.Size(264, 20);
            this.customerphonenotxt.TabIndex = 7;
            // 
            // customeremailtxt
            // 
            this.customeremailtxt.Location = new System.Drawing.Point(27, 132);
            this.customeremailtxt.Name = "customeremailtxt";
            this.customeremailtxt.Size = new System.Drawing.Size(264, 20);
            this.customeremailtxt.TabIndex = 6;
            // 
            // customernametxt
            // 
            this.customernametxt.Location = new System.Drawing.Point(27, 87);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(264, 20);
            this.customernametxt.TabIndex = 5;
            // 
            // customeridtxt
            // 
            this.customeridtxt.Location = new System.Drawing.Point(27, 38);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.Size = new System.Drawing.Size(264, 20);
            this.customeridtxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CustomerID";
            // 
            // showtable
            // 
            this.showtable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showtable.FlatAppearance.BorderSize = 0;
            this.showtable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.showtable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtable.Location = new System.Drawing.Point(303, 350);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(543, 44);
            this.showtable.TabIndex = 16;
            this.showtable.Text = "Show Customer List";
            this.showtable.UseVisualStyleBackColor = false;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // customergridview
            // 
            this.customergridview.AutoGenerateColumns = false;
            this.customergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerPhoneNoDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn});
            this.customergridview.DataSource = this.customertblBindingSource;
            this.customergridview.Location = new System.Drawing.Point(303, 73);
            this.customergridview.Name = "customergridview";
            this.customergridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customergridview.Size = new System.Drawing.Size(543, 271);
            this.customergridview.TabIndex = 15;
            this.customergridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customergridview_MouseClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "customerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "customerEmail";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // customerPhoneNoDataGridViewTextBoxColumn
            // 
            this.customerPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "customerPhoneNo";
            this.customerPhoneNoDataGridViewTextBoxColumn.HeaderText = "customerPhoneNo";
            this.customerPhoneNoDataGridViewTextBoxColumn.Name = "customerPhoneNoDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customertblBindingSource
            // 
            this.customertblBindingSource.DataMember = "customertbl";
            this.customertblBindingSource.DataSource = this.restaurantdbDataSet2BindingSource;
            // 
            // restaurantdbDataSet2BindingSource
            // 
            this.restaurantdbDataSet2BindingSource.DataSource = this.restaurantdbDataSet2;
            this.restaurantdbDataSet2BindingSource.Position = 0;
            // 
            // restaurantdbDataSet2
            // 
            this.restaurantdbDataSet2.DataSetName = "restaurantdbDataSet2";
            this.restaurantdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 29);
            this.panel1.TabIndex = 21;
            // 
            // customertblTableAdapter
            // 
            this.customertblTableAdapter.ClearBeforeFill = true;
            // 
            // generatecusID
            // 
            this.generatecusID.BackColor = System.Drawing.Color.LightSeaGreen;
            this.generatecusID.FlatAppearance.BorderSize = 0;
            this.generatecusID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.generatecusID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.generatecusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatecusID.Location = new System.Drawing.Point(6, 35);
            this.generatecusID.Name = "generatecusID";
            this.generatecusID.Size = new System.Drawing.Size(291, 24);
            this.generatecusID.TabIndex = 22;
            this.generatecusID.Text = "Generate Customer ID";
            this.generatecusID.UseVisualStyleBackColor = false;
            this.generatecusID.Click += new System.EventHandler(this.generatecusID_Click);
            // 
            // customermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 429);
            this.Controls.Add(this.generatecusID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.customergridview);
            this.Name = "customermanagement";
            this.Text = "customermanagement";
            this.Load += new System.EventHandler(this.customermanagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox customeraddresstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerphonenotxt;
        private System.Windows.Forms.TextBox customeremailtxt;
        private System.Windows.Forms.TextBox customernametxt;
        private System.Windows.Forms.TextBox customeridtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.DataGridView customergridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource restaurantdbDataSet2BindingSource;
        private restaurantdbDataSet2 restaurantdbDataSet2;
        private System.Windows.Forms.BindingSource customertblBindingSource;
        private restaurantdbDataSet2TableAdapters.customertblTableAdapter customertblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button generatecusID;
    }
}