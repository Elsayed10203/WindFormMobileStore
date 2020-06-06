using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer
{

    public partial class Frmdevice 
    {
        void fill_DataGrid()
        {
            dataGridView1.DataSource = DB.Devices.ToList();
        }

        void Fill_Combox()
        {
            Brands d = new Brands();
            comboBox1.DataSource = DB.Brands.ToList();
            comboBox1.DisplayMember = "BrandName";
            comboBox1.ValueMember = "BrandID";
        }

        void Delete_Device()
        {          
                int id = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                DB.Devices.Remove(DB.Devices.Where(x => x.DeviceID == id).SingleOrDefault());
                DB.SaveChanges();          
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

        void Hide_Frm()
        {
            if (panel_up_container.Height > 250)
            {
                panel_up_container.Height = 0;
                PanelFrm.Visible = false;
                btn_new.Enabled = true;
            }

        }

        void Show_Frm()
        {
            panel_up_container.Height = 252;
            PanelFrm.Visible = true;
            btn_new.Enabled = false;

        }
        void AddDevice()
        {
            int dev_id = DB.Devices.Select(x => x.DeviceID).Max() + 1;
            int device_count = 0;
            if (txt_quant.Text != string.Empty)
            {
                device_count = int.Parse(txt_quant.Text);
            }

            Devices dev = new Devices()
            {
                DeviceID = dev_id,
                DeviceBarcode = comboBox1.Text + "" + dev_id,
                DeviceName = txt_name.Text,
                DevicePrice = decimal.Parse(txt_pric.Text),
                DeviceNotes = txt_descrp.Text,
                BrandID = int.Parse(comboBox1.SelectedValue.ToString()),
                DeviceQuantity = device_count
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
            /*  foreach (Control x in this.Controls)
              {
                  if (x is TextBox)
                  {
                      ((TextBox)x).Text = "";
                  }
              }*/
            txt_pric.Text = txt_name.Text = txt_id.Text = txt_descrp.Text = txt_parcod.Text = txt_quant.Text = string.Empty;
            Fill_Combox();
        }

        void Handle_keypress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        
    }

}
