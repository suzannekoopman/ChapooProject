using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public class MenuItem_DAO : Base
    {
        public List<MenuItem> Db_Get_Menu_List_View_Items()
        {
            string query = $"Select [menuItemNaam], [menuItemId], [prijs], [isAlcoholisch], [voorraad], [categorieId]" +
                            $"From [menuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuItem Db_Get_MenuItem_Specific(int itemId)
        {
            string query = $"Select [menuItemNaam], [menuItemId], [prijs], [isAlcoholisch], [voorraad]" +
                            $"From [menuItem]" +
                            $"Where [menuItemId] = '{itemId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Update_Voorraad(MenuItem menuItem, OrderItem orderItem)
        {
            string query = $"Update [menuItem] Set [voorraad] = [voorraad] - '{orderItem.Aantal}' Where [menuItemId] = '{menuItem.MenuItemId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemNaam = (string)dr["menuItemNaam"],
                    MenuItemId = (int)dr["menuItemId"],
                    Prijs = (decimal)dr["prijs"],
                    IsAlcoholisch = (bool)dr["isAlcoholisch"],
                    Voorraad = (int)dr["voorraad"],
                    CategorieId = (int)dr["categorieId"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        private MenuItem ReadTable(DataTable dataTable)
        {
            MenuItem menu = new MenuItem();

            foreach (DataRow dr in dataTable.Rows)
            {
                menu.MenuItemNaam = (string)dr["menuItemNaam"];
                menu.MenuItemId = (int)dr["menuItemId"];
                menu.Prijs = (decimal)dr["prijs"];
                menu.IsAlcoholisch = (bool)dr["isAlcoholisch"];
                menu.Voorraad = (int)dr["voorraad"];
            }
            return menu;
        }
    }
}
