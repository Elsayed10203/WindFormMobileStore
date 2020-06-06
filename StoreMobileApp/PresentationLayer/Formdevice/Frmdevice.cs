using System;
using System.Data;
using System.Linq;
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
       
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Show_Frm();
            btn_new.Enabled = false;
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == string.Empty ||txt_pric.Text==string.Empty)
            {
                MessageBox.Show("قم بادخال البيانات ");
            }
            else
            {
                Devices d = DB.Devices.Where(x => x.DeviceBarcode == txt_parcod.Text).SingleOrDefault();
                if (d == null)
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
           
        }
  
     
        private void label8_Click_1(object sender, EventArgs e)
        {
            Hide_Frm();
            btn_new.Enabled = true;
            ClearFrm();
        }
      
        private void txt_pric_KeyPress(object sender, KeyPressEventArgs e)
        {
            Handle_keypress(e);
        }

        private void txt_quant_KeyPress(object sender, KeyPressEventArgs e)
        {
                        Handle_keypress(e);

        }

        private void txt_srch_TextChanged(object sender, EventArgs e)
        {
            if (txt_srch.Text == string.Empty)
            {
                fill_DataGrid();
            }
            else
            {
                dataGridView1.DataSource = DB.Devices.Where(x => x.DeviceName.Contains(txt_srch.Text)|| x.DeviceBarcode.Contains(txt_srch.Text)).ToList();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("تاكيد حذف المنتج ", "مسح العنصر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete_Device();
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "update")
            {
                Show_Frm();
                Select_update();

            }
        }

        private void Voic_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
