using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer
{
    public partial class Frmdevice : Form
    {
        Model1 DB = new Model1();
        public Frmdevice()
        {
            InitializeComponent();
            fill_DataGrid();
            Hide_Frm();
            Fill_Combox();
        }
        void Fill_Combox()
        {
            Brands d = new Brands();
            comboBox1.DataSource = DB.Brands.ToList();
            comboBox1.DisplayMember = "BrandName";
            comboBox1.ValueMember = "BrandID";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void fill_DataGrid()
        {
            dataGridView1.DataSource = DB.Devices.ToList();
        }
        void Delete_Device()
        {
             if (MessageBox.Show("تاكيد حذف المنتج ", "مسح العنصر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    DB.Devices.Remove(DB.Devices.Where(x => x.DeviceID == id).SingleOrDefault());
                    DB.SaveChanges();
                }
                fill_DataGrid();
            
        }
        void Select_update()
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_pric.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_quant.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_descrp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_id.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_parcod.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            btn_add.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                Delete_Device();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "update")
            {
                Show_Frm();
                Select_update();
                
            }
            }

            private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void Hide_Frm()
        {
            if (panel_up_container.Height > 250)
            {
                panel_up_container.Height = 0;
                PanelFrm.Visible = false;

            }

        }
     
        void Show_Frm()
        {         
                panel_up_container.Height = 252;
                PanelFrm.Visible = true;
            btn_add.Enabled = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Show_Frm();
            btn_new.Enabled = false;          
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            Devices d = DB.Devices.Where(x => x.DeviceBarcode == txt_parcod.Text).SingleOrDefault();
            if(d==null)
            {
                AddDevice();
            }
            else
            {
                UpdateDevice();
            }
            ClearFrm();
            Hide_Frm();
            fill_DataGrid();
        }
        void AddDevice()
        {
            int dev_id = DB.Devices.Select(x => x.DeviceID).Max() + 1;
            Devices dev = new Devices()
            {
                DeviceID = dev_id,
                DeviceBarcode = comboBox1.Text + "" + dev_id,
                DeviceName = txt_name.Text,
                DevicePrice = decimal.Parse(txt_pric.Text),
                DeviceNotes = txt_descrp.Text,
                BrandID = int.Parse(comboBox1.SelectedValue.ToString()),
                DeviceQuantity = int.Parse(txt_quant.Text)
            };
            DB.Devices.Add(dev);
            DB.SaveChanges();
            MessageBox.Show("تم اضافة العنصر بنجاح");
            ClearFrm();
        }
        void UpdateDevice()
        {
            int id = int.Parse(txt_id.Text);
            Devices dev = DB.Devices.Where(x => x.DeviceID == id).SingleOrDefault();
            dev.DeviceBarcode = comboBox1.Text + "" + id;
            dev.DeviceName = txt_name.Text;
            dev.DevicePrice = decimal.Parse(txt_pric.Text);
            dev.DeviceNotes = txt_descrp.Text;
            dev.BrandID = int.Parse(comboBox1.SelectedValue.ToString());
            dev.DeviceQuantity = int.Parse(txt_quant.Text);
            DB.SaveChanges();
            MessageBox.Show("تم تحديث البيانات بنجاح");
        }
        void ClearFrm()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }
        private void label8_Click_1(object sender, EventArgs e)
        {
            Hide_Frm();
            btn_new.Enabled = true;
        }
    }
}
