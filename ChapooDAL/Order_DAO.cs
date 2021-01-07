using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        public Order Db_Create_New_Order(Tafel tafel, Account account)
        {
            string query = $"Insert Into [order] (tafelId, datum, totaalPrijs, gebruikersId)" +
                            $"Values ('{tafel.TafelId}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}', 0, '{account.gebruikersId}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            string query2 = "Select top(1) [orderId] from [Order] order by [orderId] desc";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            return ReadOrderId(ExecuteSelectQuery(query2, sqlParameters2));
        }

        public void Db_Udate_Order(Order order)
        {
            string query = $"Update [order] set [totaalPrijs] = '{order.TotaalPrijs.ToString("0,00")}', [opmerking] = '{order.Opmerking}' Where [orderId] = '{order.OrderId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private Order ReadOrderId(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                order.OrderId = (int)dr["orderId"];
            }
            return order;
        }
    }
}
