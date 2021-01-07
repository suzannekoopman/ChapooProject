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
    public class Tafel_DAO : Base
    {
        public List<Tafel> Db_Get_Tafel_Data()
        {
            string query = "Select [tafelId], [tafelStatusId] from Tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Book_Tafel(int tafelId)
        {
            string query = $"Update [Tafel] Set [tafelStatusId] = 3 Where [tafelId] = '{tafelId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Tafel_Bezet(int tafelId)
        {
            string query = $"Update [Tafel] Set [tafelStatusId] = 2 Where [tafelId] = '{tafelId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    TafelId = (int)dr["tafelId"],
                    TafelStatusId = (int)dr["tafelStatusId"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
