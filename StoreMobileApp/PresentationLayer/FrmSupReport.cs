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
    public partial class FrmSupReport : Form
    {
        DataTable dt = new DataTable();
        Model1 DB = new Model1();

        CustomerReportManag CustMang = new CustomerReportManag();
        Users SystemUser = LoginMang.LoginNAME();
        public FrmSupReport()
        {
            InitializeComponent();
            txt_sal_man.Text = SystemUser.UserName;
            up_table();
            grid_resiz();
        }
        void grid_resiz()
        {
            this.dataGridView1.RowHeadersWidth = 39;
            this.dataGridView1.Columns[0].Width = 56;
            this.dataGridView1.Columns[1].Width = 107;
            this.dataGridView1.Columns[2].Width = 104;
            this.dataGridView1.Columns[3].Width = 115;
            this.dataGridView1.Columns[4].Width = 104;
            this.dataGridView1.Columns[5].Width = 116;
        }
        void up_table()
        {
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("نهاية الضمان");
            dt.Columns.Add("ثمن المنتج");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("الخصم %");
            dt.Columns.Add("المبلغ الكلي");
            dataGridView1.DataSource = dt;

        }
        void up_row()
        {
            DataRow dr = dt.NewRow();
            dr[0] = txt_prod_nme.Text;
            dr[1] = pck_expir.Text;
            dr[2] = txt_prc.Text;
            dr[3] = txt_quant.Text;
            dr[4] = txt_cah.Text;
            dr[5] = txt_disc.Text;
            dr[6] = txt_totl_prc.Text;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            clear();
            btn_prod_chooce.Focus();
        }
        private void button11_Click(object sender, EventArgs e)
        {
         
            frmSupliers frm = new frmSupliers();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();        
        }

        private void txt_cah_TextChanged(object sender, EventArgs e)
        {
        }

       
        void calculate()
        {
            if (txt_quant.Text != string.Empty && txt_prc.Text != string.Empty)

                try
                {

                    {
                        txt_cah.Text = (Convert.ToDouble(txt_prc.Text) * Convert.ToInt32(txt_quant.Text)).ToString();
                    }
                }
                catch
                {

                }
        }
      
        void total_am()
        {
            try
            {
                if (txt_cah.Text != string.Empty && txt_disc.Text != string.Empty)
                {
                    double disc = Convert.ToDouble(txt_disc.Text);
                    double amount = Convert.ToDouble(txt_cah.Text);
                    txt_totl_prc.Text = (amount - (amount * (disc / 100))).ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_prod_chooce_Click(object sender, EventArgs e)
        {

        }

      
        void clear()
        {
            txt_prc.Text = txt_prc.Text = txt_prod_nme.Text = txt_quant.Text = txt_disc.Text = string.Empty;
        }
        void lbl_sum()
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    txt_the_sum.Text = sum.ToString();
                }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            frmSupliers frm = new frmSupliers();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
      
        void up_ord_det()
        {
            try
            {
                int id = int.Parse(txt_prod_nme.Text);
               Devices devic=DB.Devices.Where(x => x.DeviceID == id).SingleOrDefault();
                OrdersDetails ord_det = new OrdersDetails();
                ord_det.OrderID = int.Parse(txt_ord_id.Text);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ord_det.DeviceID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    ord_det.UnitPrice =decimal.Parse( dataGridView1.Rows[i].Cells[2].Value.ToString());
                    ord_det.Quantity = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    ord_det.OrderDetailsNotes = txt_descrp.Text;
                    ord_det.DeviceID = devic.DeviceID;
                    ord_det.SellingPrice = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    ord_det.TotalPrice =decimal.Parse( dataGridView1.Rows[i].Cells[4].Value.ToString());
                    DB.OrdersDetails.Add(ord_det);
                    DB.SaveChanges();
                }
            }
            catch { }
        }
        void UPOrder()
        {
            Orders ord = new Orders()
        {
            OrderID = int.Parse(txt_ord_id.Text),
                OrderDate = dateTimePicker1.Value,
                 OrderTotalPrice = decimal.Parse(txt_the_sum.Text),
                CustomerName = txt_cus_fnam.Text,
                UserID = SystemUser.UserID,
                OrderNotes = txt_descrp.Text
            };
            DB.Orders.Add(ord);
            DB.SaveChanges();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UPOrder();
            up_ord_det();
            MessageBox.Show("تم الاضافة بنجاح");
            dt.Clear();
            dataGridView1.Refresh();
            txt_the_sum.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_ord_id.Text =CustMang.NewOrderNo().ToString();
        }

        private void txt_quant_TextChanged_1(object sender, EventArgs e)
        {
            txt_cah.Clear();
            calculate();
        }

        private void txt_disc_TextChanged_1(object sender, EventArgs e)
        {
            txt_totl_prc.Clear();
            total_am();
        }

        private void txt_disc_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_disc.Text != string.Empty)
            {
                up_row();
                clear();
                lbl_sum();
            }
        }
    }
}
