using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Account_DAO : Base
    {
        public List<Account> Db_Get_All_Accounts()
        {
            string query = "SELECT Gebruikersnaam, Hash, gebruikersId, Vraag, Antwoord, functieId FROM Gebruiker";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Account> ReadTables(DataTable dataTable)
        {
            List<Account> accounts = new List<Account>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Account account = new Account()
                {
                    Gebruikersnaam = (String)dr["Gebruikersnaam"],
                    Wachtwoord = (String)dr["Hash"],
                    gebruikersId = (int)dr["gebruikersId"],
                    Vraag = (String)dr["Vraag"],
                    Antwoord = (String)dr["Antwoord"],
                    FunctieId = (int)dr["functieId"]
                };
                accounts.Add(account);
            }
            return accounts;
        }

        public void AlterAccount(string gebruikersnaam, string toChange, string newValue)
        {
            String query = $"UPDATE Gebruiker SET {toChange} = '{newValue}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterPassword(string gebruikersnaam, string hash, string salt)
        {
            String query = $"UPDATE Gebruiker SET Hash = '{hash}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);

            String query2 = $"UPDATE Gebruiker SET Salt = '{salt}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query2, sqlParameters2);
        }

        public string Antwoord(Account account)
        {
            String AntwoordQuery = $"select Antwoord from Gebruiker where Gebruikersnaam = '{account.gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable readAntwoord = ExecuteSelectQuery(AntwoordQuery, sqlParameters);
            foreach (DataRow dr in readAntwoord.Rows)
            {
                account.Antwoord = (String)dr["Antwoord"];
            }
            return account.Antwoord;
        }

        public string Vraag(Account account)
        {
            String VraagQuery = $"select Vraag from Gebruiker where Gebruikersnaam = '{account.gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable readVraag = ExecuteSelectQuery(VraagQuery, sqlParameters);
            foreach (DataRow dr in readVraag.Rows)
            {
                account.Vraag = (String)dr["Vraag"];
            }
            return account.Vraag;
        }

        public int Functie(Account account)
        {
            String FunctieQuery = $"select functieId from Gebruiker where Gebruikersnaam = '{account.gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable readFunctie = ExecuteSelectQuery(FunctieQuery, sqlParameters);
            foreach (DataRow dr in readFunctie.Rows)
            {
                account.FunctieId = (int)dr["functieId"];
            }
            return account.FunctieId;
        }

        public string GetSalt(Account account)
        {
            String query = $"SELECT Salt From Gebruiker WHERE Gebruikersnaam = '{account.Gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable acc = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in acc.Rows)
            {
                account.Salt = (String)dr["Salt"];
            }
            return account.Salt;
        }
    }
}