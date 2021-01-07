using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Tafel_Service
    {
        Tafel_DAO tafel_db = new Tafel_DAO();

        public List<Tafel> GetTafelData()
        {
            return tafel_db.Db_Get_Tafel_Data();
        }

        public void BookTafel(int tafelId)
        {
            tafel_db.Db_Book_Tafel(tafelId);
        }

        public void TafelBezet(int tafelId)
        {
            tafel_db.Db_Tafel_Bezet(tafelId);
        }
    }
}
