using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMobileApp.PresentationLayer.FormAllOrders
{
    public partial class FrmOrdersAll 
    {
        Model1 DB = new Model1();
      void Fill_Gidview()
        {
            
            grd_Order.DataSource = DB.Orders.ToList();
        }
        void Fill_Compobox()
        {
            for (int i = 0; i < grd_Order.ColumnCount; i++)
            {
                if (i < 4)
                {
                    cmbx_sort.Items.Add(grd_Order.Columns[i].HeaderText);
                }
            }
           
        }
    }
}
