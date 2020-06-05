namespace StoreMobileApp.PresentationLayer
{
    partial class Frmdevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdevice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_up_container = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_parcod = new System.Windows.Forms.TextBox();
            this.PanelFrm = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descrp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pric = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.brandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_up_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelFrm.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel_up_container);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 576);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 66);
            this.panel3.TabIndex = 2;
            // 
            // panel_up_container
            // 
            this.panel_up_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.panel_up_container.Controls.Add(this.PanelFrm);
            this.panel_up_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_up_container.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel_up_container.Location = new System.Drawing.Point(0, 66);
            this.panel_up_container.Name = "panel_up_container";
            this.panel_up_container.Size = new System.Drawing.Size(1069, 255);
            this.panel_up_container.TabIndex = 3;
            this.panel_up_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(489, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
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
            this.delete,
            this.update});
            this.dataGridView1.DataSource = this.devicesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 255);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 255);
            this.panel2.TabIndex = 17;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.btn_new.ForeColor = System.Drawing.Color.Cyan;
            this.btn_new.Location = new System.Drawing.Point(3, 6);
            this.btn_new.Name = "btn_new";
            this.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_new.Size = new System.Drawing.Size(67, 66);
            this.btn_new.TabIndex = 50;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_parcod
            // 
            this.txt_parcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcod.Location = new System.Drawing.Point(250, 19);
            this.txt_parcod.Name = "txt_parcod";
            this.txt_parcod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_parcod.Size = new System.Drawing.Size(217, 29);
            this.txt_parcod.TabIndex = 36;
            this.txt_parcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelFrm
            // 
            this.PanelFrm.Controls.Add(this.panel4);
            this.PanelFrm.Controls.Add(this.label7);
            this.PanelFrm.Controls.Add(this.label8);
            this.PanelFrm.Controls.Add(this.txt_descrp);
            this.PanelFrm.Controls.Add(this.btn_add);
            this.PanelFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFrm.Location = new System.Drawing.Point(0, 0);
            this.PanelFrm.Name = "PanelFrm";
            this.PanelFrm.Size = new System.Drawing.Size(1069, 255);
            this.PanelFrm.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.txt_id);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_quant);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_pric);
            this.panel4.Controls.Add(this.txt_parcod);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_name);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(498, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 255);
            this.panel4.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 42);
            this.label8.TabIndex = 50;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(174, 66);
            this.btn_add.TabIndex = 48;
            this.btn_add.Text = "حفظ البيانات";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 85);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(212, 32);
            this.comboBox1.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(468, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 37);
            this.label5.TabIndex = 42;
            this.label5.Text = "الاسم ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(250, 160);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(217, 26);
            this.txt_name.TabIndex = 41;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(468, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "النوع";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "تفاصيل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_descrp
            // 
            this.txt_descrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrp.Location = new System.Drawing.Point(66, 77);
            this.txt_descrp.Multiline = true;
            this.txt_descrp.Name = "txt_descrp";
            this.txt_descrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_descrp.Size = new System.Drawing.Size(388, 85);
            this.txt_descrp.TabIndex = 52;
            this.txt_descrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 37);
            this.label6.TabIndex = 51;
            this.label6.Text = "الكمية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quant.Location = new System.Drawing.Point(20, 89);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_quant.Size = new System.Drawing.Size(144, 26);
            this.txt_quant.TabIndex = 50;
            this.txt_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(176, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 37);
            this.label4.TabIndex = 49;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pric
            // 
            this.txt_pric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pric.Location = new System.Drawing.Point(20, 168);
            this.txt_pric.Name = "txt_pric";
            this.txt_pric.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pric.Size = new System.Drawing.Size(144, 29);
            this.txt_pric.TabIndex = 48;
            this.txt_pric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "الباركود";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "حذف";
            this.delete.ToolTipText = "حذف العنصر المحدد";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 75;
            // 
            // update
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.DefaultCellStyle = dataGridViewCellStyle4;
            this.update.HeaderText = "تعديل";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Text = "تعديل";
            this.update.ToolTipText = "تعديل العنصر المحدد";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 62;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(38, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(126, 26);
            this.txt_id.TabIndex = 54;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Frmdevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmdevice";
            this.Text = "Frmdevice";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_up_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelFrm.ResumeLayout(false);
            this.PanelFrm.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.Panel panel_up_container;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel PanelFrm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_descrp;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pric;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_parcod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        public System.Windows.Forms.TextBox txt_id;
    }
}