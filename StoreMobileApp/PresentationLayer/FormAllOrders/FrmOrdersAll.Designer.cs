namespace StoreMobileApp.PresentationLayer.FormAllOrders
{
    partial class FrmOrdersAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdersAll));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbx_sort = new System.Windows.Forms.ComboBox();
            this.Voic_Search = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grd_Order = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 15F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grd_Order);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "عرض جميع المبيعات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 10);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.cmbx_sort);
            this.panel2.Controls.Add(this.Voic_Search);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_srch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 60);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbx_sort
            // 
            this.cmbx_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sort.FormattingEnabled = true;
            this.cmbx_sort.Location = new System.Drawing.Point(284, 9);
            this.cmbx_sort.Name = "cmbx_sort";
            this.cmbx_sort.Size = new System.Drawing.Size(164, 37);
            this.cmbx_sort.TabIndex = 55;
            this.cmbx_sort.SelectedIndexChanged += new System.EventHandler(this.cmbx_sort_SelectedIndexChanged);
            // 
            // Voic_Search
            // 
            this.Voic_Search.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Voic_Search.ForeColor = System.Drawing.Color.White;
            this.Voic_Search.Image = ((System.Drawing.Image)(resources.GetObject("Voic_Search.Image")));
            this.Voic_Search.Location = new System.Drawing.Point(32, 0);
            this.Voic_Search.Name = "Voic_Search";
            this.Voic_Search.Size = new System.Drawing.Size(80, 52);
            this.Voic_Search.TabIndex = 54;
            this.Voic_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(839, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 52);
            this.label9.TabIndex = 52;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_srch
            // 
            this.txt_srch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(616, 12);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_srch.Size = new System.Drawing.Size(217, 29);
            this.txt_srch.TabIndex = 51;
            this.txt_srch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_srch.TextChanged += new System.EventHandler(this.txt_srch_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "عرض جميع التقارير";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grd_Order
            // 
            this.grd_Order.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.grd_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Order.AutoGenerateColumns = false;
            this.grd_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(25)))));
            this.grd_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Order.ColumnHeadersHeight = 30;
            this.grd_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderTotalPriceDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.orderNotesDataGridViewTextBoxColumn,
            this.select});
            this.grd_Order.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Order.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Order.EnableHeadersVisualStyles = false;
            this.grd_Order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.grd_Order.Location = new System.Drawing.Point(3, 63);
            this.grd_Order.Name = "grd_Order";
            this.grd_Order.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grd_Order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 18F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.grd_Order.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grd_Order.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.grd_Order.RowTemplate.Height = 30;
            this.grd_Order.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Order.Size = new System.Drawing.Size(965, 416);
            this.grd_Order.TabIndex = 27;
            this.grd_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Order_CellClick);
            this.grd_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Order_CellContentClick);
            // 
            // select
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select.DefaultCellStyle = dataGridViewCellStyle3;
            this.select.HeaderText = "اختيار";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Text = "تفاصيل";
            this.select.ToolTipText = "اختيار";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 91;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "تاريخ البيع";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 135;
            // 
            // orderTotalPriceDataGridViewTextBoxColumn
            // 
            this.orderTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderTotalPrice";
            this.orderTotalPriceDataGridViewTextBoxColumn.HeaderText = "المبلغ الكلي";
            this.orderTotalPriceDataGridViewTextBoxColumn.Name = "orderTotalPriceDataGridViewTextBoxColumn";
            this.orderTotalPriceDataGridViewTextBoxColumn.Width = 161;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 156;
            // 
            // orderNotesDataGridViewTextBoxColumn
            // 
            this.orderNotesDataGridViewTextBoxColumn.DataPropertyName = "OrderNotes";
            this.orderNotesDataGridViewTextBoxColumn.HeaderText = "تفاصيل";
            this.orderNotesDataGridViewTextBoxColumn.Name = "orderNotesDataGridViewTextBoxColumn";
            this.orderNotesDataGridViewTextBoxColumn.Width = 106;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(StoreMobileApp.Orders);
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataSource = typeof(StoreMobileApp.Devices);
            // 
            // FrmOrdersAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 530);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdersAll";
            this.Text = "FrmOrdersAll";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Voic_Search;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.ComboBox cmbx_sort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grd_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}