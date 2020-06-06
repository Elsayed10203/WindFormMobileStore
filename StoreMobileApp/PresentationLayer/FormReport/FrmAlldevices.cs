using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer.FormReport
{

    public partial class FrmAlldevices : Form
    {
        Model1 DB = new Model1();
        public FrmAlldevices()
        {
            InitializeComponent();
            fill_DataGrid();
        }
        void fill_DataGrid()
        {
            dataGridView1.DataSource = DB.Devices.ToList();
        }
        private void txt_srch_TextChanged(object sender, EventArgs e)
        {
            if (txt_srch.Text == string.Empty)
            {
                fill_DataGrid();
            }
            else
            {
                dataGridView1.DataSource = DB.Devices.Where(x => x.DeviceName.Contains(txt_srch.Text) || x.DeviceBarcode.Contains(txt_srch.Text)).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "select")
            {
                GridViewSelectItem();
            }
        }
        void GridViewSelectItem()
        {
            FrmSupReport frm = Owner as FrmSupReport;
            frm.txt_parcode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txt_brand.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_prc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txt_quant.Focus();
            this.Close();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridViewSelectItem();
        }
    }
}
