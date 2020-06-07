using StoreMobileApp.PresentationLayer.FormReport;
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

        private void btn_prod_chooce_Click(object sender, EventArgs e)
        {

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
            /* frmSupliers frm = new frmSupliers();
             AddOwnedForm(frm);
             frm.FormBorderStyle = FormBorderStyle.None;
             frm.TopLevel = false;
             frm.Dock = DockStyle.Fill;
             this.Controls.Add(frm);
             this.Tag = frm;
             frm.BringToFront();
             frm.Show();*/
            SelectFrm(new frmSupliers());
        }
      
       
        private void button3_Click(object sender, EventArgs e)
        {
            btn_new_Click(null,null);
            try
            {
             UPOrder();
            up_ord_det();
            MessageBox.Show("تم الاضافة بنجاح");
            dt.Clear();
            dataGridView1.Refresh();
            txt_the_sum.Text = "";
            }
           catch
            {
                MessageBox.Show("قم بادخال البيانات كاملة");
            }
         
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

        private void txt_disc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Handle_Press(e);
        }
      

        private void txt_quant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Handle_Press(e);
        }

        private void btn_prod_chooce_Click_1(object sender, EventArgs e)
        {
            SelectFrm(new FrmAlldevices());
            
        }

     

        private void txt_quant_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDown(e, txt_disc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void btn_prnd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            lbl_sum();
        }
    }
}
