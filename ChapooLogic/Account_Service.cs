using System;
using ChapooDAL;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Account_Service
    {
        static Account_DAO account_db = new Account_DAO();

        public List<Account> GetAccounts()
        {
            try
            {
                List<Account> account = account_db.Db_Get_All_Accounts();
                return account;
            }
            catch (Exception)
            {
                List<Account> account = new List<Account>();
                Account a = new Account();
                a.Gebruikersnaam = "Pieter";
                a.Wachtwoord = "Welkom01";
                a.gebruikersId = 1000;
                account.Add(a);

                return account;
            }
        }

        public void AlterPassword(string gebruikersnaam, string hash, string salt)
        {
            account_db.AlterPassword(gebruikersnaam, hash, salt);
        }

        public string ForgotPassword_vraag(Account account)
        {
            return account_db.Vraag(account);
        }

        public string ForgotPassword_antwoord(Account account)
        {
            return account_db.Antwoord(account);
        }

        public string GetSalt(Account account)
        {
            return account_db.GetSalt(account);
        }
    }
}
