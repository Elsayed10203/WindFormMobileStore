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
    public partial class FrmCatag : Form
    {
        Model1 DB = new Model1();
        public static int CatNo = 1;
        public FrmCatag()
        {
            InitializeComponent();
            button1_Click(null,null);
            fill_GridView();
        }
        void fill_GridView()
        {
            dataGridView1.DataSource = DB.Brands.ToList();
        }
        void clear_txt()
        {
             txt_name.Text = txt_details.Text = string.Empty;
        }
        void AddBrand()
        {
            Brands B = new Brands()
            {
                BrandID = DB.Brands.Select(x => x.BrandID).Max() + 1,
                BrandName = txt_name.Text,
                BrandNotes = txt_details.Text,
            };
            DB.Brands.Add(B);
            DB.SaveChanges();
            MessageBox.Show("تم اضافة الصنف بنجاح");
        }
        void UpdateBrand()
        {
            int id = int.Parse(txt_cat_id.Text);
            Brands br = DB.Brands.Where(x => x.BrandID == id).SingleOrDefault();
            br.BrandID = int.Parse(txt_cat_id.Text);
            br.BrandName = txt_name.Text;
            br.BrandNotes = txt_details.Text;
            DB.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح");
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text !="")
            {
                int id = int.Parse(txt_cat_id.Text);
                Brands bran = DB.Brands.Where(x => x.BrandID == id).SingleOrDefault();
                if(bran==null)
                {
                AddBrand();
                }
                else
                {
                    UpdateBrand();
                }
                btn_add.Enabled = false;
                clear_txt();
                fill_GridView();
                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("قم بادخال البيانات");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CatNo = DB.Brands.Select(x => x.BrandID).Max() + 1;
            btn_add.Enabled = true;
            txt_cat_id.Text = CatNo.ToString();
            clear_txt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("تاكيد حذف المنتج ", "مسح العنصر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    DB.Brands.Remove(DB.Brands.Where(x => x.BrandID == id).SingleOrDefault());
                    DB.SaveChanges();
                }
                fill_GridView();
                button1_Click(null, null);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                txt_cat_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_details.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                btn_add.Enabled = true;
               
            }

        }
    }
}
