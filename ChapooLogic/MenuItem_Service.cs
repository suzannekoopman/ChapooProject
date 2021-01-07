using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        MenuItem_DAO menuItem_db = new MenuItem_DAO();

        public List<MenuItem> GetMenuListViewItems()
        {
            return menuItem_db.Db_Get_Menu_List_View_Items();
        }
        public MenuItem GetMenuItemsSpecific(int itemId)
        {
            return menuItem_db.Db_Get_MenuItem_Specific(itemId);
        }
        public void UpdateVoorraad(MenuItem menuItem, OrderItem orderItem)
        {
            menuItem_db.Db_Update_Voorraad(menuItem, orderItem);
        }
    }
}
