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
    public partial class frmSupliers : Form
    {
        public frmSupliers()
        {
            InitializeComponent();
            fillgridSupliers();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
    
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAddSuplier frm = new frmAddSuplier();
            frm.ShowDialog();
        }
        private void fillgridSupliers()
        {
            dataGridView1.Rows.Insert(0, "1", "زغلول", "فرع المنصورة", "010101010", "نصاب خلي بالك");
            dataGridView1.Rows.Insert(1, "2", "نصر", "فرع المنصورة", "010101010", "نصورة"); 
            dataGridView1.Rows.Insert(2, "1", "علي", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(3, "2", "حسناء", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(2, "1", "خلود", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(3, "2", "نصر", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(2, "1", "علي", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(3, "2", "نصر", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(2, "1", "علي", "فرع المنصورة", "010101010", "تفاصيل");
            dataGridView1.Rows.Insert(3, "2", "نصر", "فرع المنصورة", "010101010", "تفاصيل");

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
     

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddSuplier frm = new frmAddSuplier();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txt_branch.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txt_telph.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txt_descr.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("تعديله قم باختيار الصف المراد ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        int id=int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show($"supplier is : {id}");


        }
        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FrmSupReport frm = Owner as FrmSupReport;
            frm.txt_cust_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            frm.txt_cust_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_cus_fnam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
