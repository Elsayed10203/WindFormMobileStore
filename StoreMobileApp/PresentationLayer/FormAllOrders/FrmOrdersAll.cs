using StoreMobileApp.PresentationLayer.FormOrderDtails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer.FormAllOrders
{
    public partial class FrmOrdersAll : Form
    {
        public FrmOrdersAll()
        {
            InitializeComponent();
            Fill_Gidview();
            Fill_Compobox();
        }
       
        private void txt_srch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_srch_TextChanged_1(object sender, EventArgs e)
        {
            if(txt_srch.Text!=string.Empty)
            {
                grd_Order.DataSource = DB.Orders.Where(x => x.CustomerName.Contains(txt_srch.Text)).ToList();
            }
            else
            {
                Fill_Gidview();
            }
        }

        private void grdvorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbx_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
             int indx = cmbx_sort.SelectedIndex;
            switch (indx)
            {
                case 0:
                    grd_Order.DataSource = DB.Orders.OrderBy(x => x.OrderID).ToList();
                    break;
                case 1:
                    grd_Order.DataSource = DB.Orders.OrderBy(x => x.OrderDate).ToList();
                    break;
                case 2:
                    grd_Order.DataSource = DB.Orders.OrderBy(x => x.OrderTotalPrice).ToList();
                    break;
                case 3:
                    grd_Order.DataSource = DB.Orders.OrderBy(x => x.CustomerName).ToList();
                    break;
                default:
                    Fill_Gidview();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void grd_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = int.Parse(grd_Order.CurrentRow.Cells[0].Value.ToString());
            if (grd_Order.Columns[e.ColumnIndex].Name == "select")
            {
                FrmOrderDetails frm = new FrmOrderDetails(_id);
                frm.cust_name.Text = grd_Order.CurrentRow.Cells[3].Value.ToString();
                frm.Order_No.Text = _id.ToString();
                frm.ShowDialog();
            }

        }

        private void grd_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //dont work
        void SelectFrm(Form frm)
        {
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
           
        }
    }
}
