namespace StoreMobileApp.PresentationLayer.FormOrderDtails
{
    partial class FrmOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cust_name = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Order_No = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_details = new System.Windows.Forms.DataGridView();
            this.ordersDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cust_name);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 80);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(891, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 55);
            this.label2.TabIndex = 37;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cust_name
            // 
            this.cust_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cust_name.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cust_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cust_name.Location = new System.Drawing.Point(543, 31);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(175, 40);
            this.cust_name.TabIndex = 5;
            this.cust_name.Text = "علي علي ";
            this.cust_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cust_name.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Order_No);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 80);
            this.panel2.TabIndex = 3;
            // 
            // Order_No
            // 
            this.Order_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_No.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Order_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Order_No.Location = new System.Drawing.Point(25, 28);
            this.Order_No.Name = "Order_No";
            this.Order_No.Size = new System.Drawing.Size(129, 40);
            this.Order_No.TabIndex = 2;
            this.Order_No.Text = "111";
            this.Order_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order_No.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(148, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 68);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(724, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 68);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grid_details
            // 
            this.grid_details.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.grid_details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_details.AutoGenerateColumns = false;
            this.grid_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.grid_details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_details.ColumnHeadersHeight = 30;
            this.grid_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.deviceIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.orderDetailsNotesDataGridViewTextBoxColumn,
            this.select});
            this.grid_details.DataSource = this.ordersDetailsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_details.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_details.EnableHeadersVisualStyles = false;
            this.grid_details.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.grid_details.Location = new System.Drawing.Point(0, 80);
            this.grid_details.Name = "grid_details";
            this.grid_details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid_details.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_details.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.grid_details.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_details.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.grid_details.RowTemplate.Height = 30;
            this.grid_details.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_details.Size = new System.Drawing.Size(943, 370);
            this.grid_details.TabIndex = 35;
            // 
            // ordersDetailsBindingSource
            // 
            this.ordersDetailsBindingSource.DataSource = typeof(StoreMobileApp.OrdersDetails);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "رقم الفاتورة";
            this.OrderID.Name = "OrderID";
            this.OrderID.Width = 150;
            // 
            // deviceIDDataGridViewTextBoxColumn
            // 
            this.deviceIDDataGridViewTextBoxColumn.DataPropertyName = "DeviceID";
            this.deviceIDDataGridViewTextBoxColumn.HeaderText = "رقم الجهاز";
            this.deviceIDDataGridViewTextBoxColumn.Name = "deviceIDDataGridViewTextBoxColumn";
            this.deviceIDDataGridViewTextBoxColumn.Width = 138;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "ثمن الشراء";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 148;
            // 
            // orderDetailsNotesDataGridViewTextBoxColumn
            // 
            this.orderDetailsNotesDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailsNotes";
            this.orderDetailsNotesDataGridViewTextBoxColumn.HeaderText = "تفاصيل";
            this.orderDetailsNotesDataGridViewTextBoxColumn.Name = "orderDetailsNotesDataGridViewTextBoxColumn";
            this.orderDetailsNotesDataGridViewTextBoxColumn.Width = 106;
            // 
            // select
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select.DefaultCellStyle = dataGridViewCellStyle3;
            this.select.HeaderText = "طباعة";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Text = "تفاصيل";
            this.select.ToolTipText = "طباعة الفاتورة";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 96;
            // 
            // FrmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.grid_details);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmOrderDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmOrderDetails";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ordersDetailsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_details;
        public System.Windows.Forms.Button cust_name;
        public System.Windows.Forms.Button Order_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}