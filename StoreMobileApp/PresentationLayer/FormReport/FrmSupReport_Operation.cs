using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer
{
    public partial class FrmSupReport 
    {
        DataTable dt = new DataTable();

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
            dt.Columns.Add("الباركود");
            dt.Columns.Add("نوع المنتج");
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
            dr[0] = txt_parcode.Text;
            dr[1] = txt_brand.Text;
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
        void Handle_Press(KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        void clear()
        {
            txt_prc.Text = txt_prc.Text = txt_parcode.Text = txt_quant.Text = txt_disc.Text = string.Empty;
        }
        void lbl_sum()
        {
            try
            {
                
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    txt_the_sum.Text = sum.ToString();
                }
            }
            catch { }
        }
        void up_ord_det()
        {
            try
            {
                /* int id = int.Parse(txt_parcode.Text);
                 Devices devic = DB.Devices.Where(x => x.DeviceID == id).SingleOrDefault();*/

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    OrdersDetails ord_det = new OrdersDetails();
                    ord_det.OrderID = int.Parse(txt_ord_id.Text);
                    ord_det.DeviceID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    ord_det.UnitPrice = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    ord_det.Quantity = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    ord_det.OrderDetailsNotes = txt_descrp.Text;
                    //ord_det.DeviceID = devic.DeviceID;
                    ord_det.DeviceID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    ord_det.SellingPrice = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    ord_det.TotalPrice = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
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
        void HandleKeyDown(KeyEventArgs e, Control cont)
        {
            if (e.KeyCode == Keys.Enter && txt_quant.Text != string.Empty)
            {
                cont.Focus();
            }
        }
        void UpdateRow()
        {
            try
            {
                txt_parcode.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_brand.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_prc.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_quant.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_cah.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_disc.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_totl_prc.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                lbl_sum();
            }
            catch
            {

            }
        }

    }
}
