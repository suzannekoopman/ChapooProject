using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL
{
    public class OrderItem_DAO : Base
    {
        public void Db_Add_New_OrderItem(OrderItem orderItem)
        {
            string query = $"Insert Into [orderItem] (orderId, aantal, bestelTijd, orderStatusId, menuItemId)" +
                            $"Values ({orderItem.Order.OrderId}, {orderItem.Aantal}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {orderItem.OrderStatusId}, {orderItem.MenuItemId})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> Db_Get_OrderItems(int orderId)
        {
            string query = $"Select [menuItemId], [aantal], [orderItemId], [orderStatusId] From orderItem Where [orderId] = '{orderId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Remove_OrderItem(int orderItemId)
        {
            string query = $"Delete From [orderItem] Where [orderItemId] = '{orderItemId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Edit_OrderItem(int orderItemId, int aantal)
        {
            string query = $"Update [orderItem] Set [aantal] = [aantal] + '{aantal}' Where [orderItemId] = '{orderItemId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    MenuItemId = (int)dr["menuItemId"],
                    Aantal = (int)dr["aantal"],
                    OrderItemId = (int)dr["orderItemId"],
                    OrderStatusId = (int)dr["orderStatusId"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}
