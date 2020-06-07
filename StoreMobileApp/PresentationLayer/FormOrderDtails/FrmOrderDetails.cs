using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer.FormOrderDtails
{
    public partial class FrmOrderDetails : Form
    {
        Model1 DB = new Model1();
        public static int _prd = 0;
        public FrmOrderDetails(int order_id)
        {
            InitializeComponent();
            _prd = order_id;
            fill_datagid();
        }
        void fill_datagid()
        {
            grid_details.DataSource = DB.OrdersDetails.Where(x=>x.OrderID== _prd).ToList();
            Order_No.Text = DB.OrdersDetails.ToList().Count().ToString();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
