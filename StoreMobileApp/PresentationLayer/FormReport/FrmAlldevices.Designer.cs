namespace StoreMobileApp.PresentationLayer.FormReport
{
    partial class FrmAlldevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlldevices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Voic_Search = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.brandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.Voic_Search);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_srch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 60);
            this.panel2.TabIndex = 21;
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
            this.label9.Location = new System.Drawing.Point(894, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 52);
            this.label9.TabIndex = 52;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_srch
            // 
            this.txt_srch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch.Location = new System.Drawing.Point(671, 12);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_srch.Size = new System.Drawing.Size(217, 29);
            this.txt_srch.TabIndex = 51;
            this.txt_srch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_srch.TextChanged += new System.EventHandler(this.txt_srch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandsDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.devicePriceDataGridViewTextBoxColumn,
            this.deviceQuantityDataGridViewTextBoxColumn,
            this.deviceNotesDataGridViewTextBoxColumn,
            this.deviceIDDataGridViewTextBoxColumn,
            this.deviceBarcodeDataGridViewTextBoxColumn,
            this.select});
            this.dataGridView1.DataSource = this.devicesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 432);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // select
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select.DefaultCellStyle = dataGridViewCellStyle3;
            this.select.HeaderText = "اختيار الصف المحدد";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Text = "اختيار";
            this.select.ToolTipText = "اختيار الصف المحدد";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 192;
            // 
            // brandsDataGridViewTextBoxColumn
            // 
            this.brandsDataGridViewTextBoxColumn.DataPropertyName = "Brands";
            this.brandsDataGridViewTextBoxColumn.HeaderText = "نوع المنتج";
            this.brandsDataGridViewTextBoxColumn.Name = "brandsDataGridViewTextBoxColumn";
            this.brandsDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandsDataGridViewTextBoxColumn.Width = 118;
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "اسم الجهاز";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            this.deviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // devicePriceDataGridViewTextBoxColumn
            // 
            this.devicePriceDataGridViewTextBoxColumn.DataPropertyName = "DevicePrice";
            this.devicePriceDataGridViewTextBoxColumn.HeaderText = "ثمن البيع";
            this.devicePriceDataGridViewTextBoxColumn.Name = "devicePriceDataGridViewTextBoxColumn";
            this.devicePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.devicePriceDataGridViewTextBoxColumn.Width = 110;
            // 
            // deviceQuantityDataGridViewTextBoxColumn
            // 
            this.deviceQuantityDataGridViewTextBoxColumn.DataPropertyName = "DeviceQuantity";
            this.deviceQuantityDataGridViewTextBoxColumn.HeaderText = "العدد المتاح";
            this.deviceQuantityDataGridViewTextBoxColumn.Name = "deviceQuantityDataGridViewTextBoxColumn";
            this.deviceQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceQuantityDataGridViewTextBoxColumn.Width = 129;
            // 
            // deviceNotesDataGridViewTextBoxColumn
            // 
            this.deviceNotesDataGridViewTextBoxColumn.DataPropertyName = "DeviceNotes";
            this.deviceNotesDataGridViewTextBoxColumn.HeaderText = "تفاصيل";
            this.deviceNotesDataGridViewTextBoxColumn.Name = "deviceNotesDataGridViewTextBoxColumn";
            this.deviceNotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceNotesDataGridViewTextBoxColumn.Width = 92;
            // 
            // deviceIDDataGridViewTextBoxColumn
            // 
            this.deviceIDDataGridViewTextBoxColumn.DataPropertyName = "DeviceID";
            this.deviceIDDataGridViewTextBoxColumn.HeaderText = "رقم الجهاز";
            this.deviceIDDataGridViewTextBoxColumn.Name = "deviceIDDataGridViewTextBoxColumn";
            this.deviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceIDDataGridViewTextBoxColumn.Width = 118;
            // 
            // deviceBarcodeDataGridViewTextBoxColumn
            // 
            this.deviceBarcodeDataGridViewTextBoxColumn.DataPropertyName = "DeviceBarcode";
            this.deviceBarcodeDataGridViewTextBoxColumn.HeaderText = "الباركود";
            this.deviceBarcodeDataGridViewTextBoxColumn.Name = "deviceBarcodeDataGridViewTextBoxColumn";
            this.deviceBarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceBarcodeDataGridViewTextBoxColumn.Width = 93;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataSource = typeof(StoreMobileApp.Devices);
            // 
            // FrmAlldevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1020, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlldevices";
            this.Text = "FrmAlldevices";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Voic_Search;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}