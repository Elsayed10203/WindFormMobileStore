using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMobileApp
{
    class CustomerReportManag
    {
        Model1 DB = new Model1();
       public void AddOrder(Orders ord)
        {
            if(ord !=null)
            {
              DB.Orders.Add(ord);
            }
            DB.SaveChanges();      

        }
        public int NewOrderNo()
        {
            if(DB.Orders.Count()>1)
            {
                return DB.Orders.Select(x => x.OrderID + 1).Max();
            }
            else
            {
                return 1;
            }

        }
    }
}
