using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class OrderItem_Service
    {
        OrderItem_DAO orderItem_db = new OrderItem_DAO();

        public void CreateOrderItem(OrderItem orderItem)
        {
            orderItem_db.Db_Add_New_OrderItem(orderItem);
        }
        public List<OrderItem> GetOrderItems(int orderId)
        {
            return orderItem_db.Db_Get_OrderItems(orderId);
        }
        public void RemoveOrderItem(int orderItemId)
        {
            orderItem_db.Db_Remove_OrderItem(orderItemId);
        }
        public void EditOrderItem(int orderItemId, int aantal)
        {
            orderItem_db.Db_Edit_OrderItem(orderItemId, aantal);
        }
    }
}
