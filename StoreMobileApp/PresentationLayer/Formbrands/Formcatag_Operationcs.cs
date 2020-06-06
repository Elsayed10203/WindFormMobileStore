using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer
{
    public partial class FrmCatag :Form

    {
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
    }
}
