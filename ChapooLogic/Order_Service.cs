using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Order_Service
    {
        Order_DAO order_db = new Order_DAO();

        public Order CreateOrder(Tafel tafel, Account account)
        {
            return order_db.Db_Create_New_Order(tafel, account);
        }

        public void UpdateOrder(Order order)
        {
            order_db.Db_Udate_Order(order);
        }
    }
}
