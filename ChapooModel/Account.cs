using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Account
    {
        public string gebruikersnaam;
        public string wachtwoord;
        public int gebruikersId;
        public int FunctieId;
        public String Vraag { get; set; }
        public String Antwoord { get; set; }
        public String Salt { get; set; }
        

        public Account()
        {
        }

        public Account(string txt_gebruikersnaam, string txt_wachtwoord, int gebruikersId, string vraag, string antwoord, int functieId)
        {
            Gebruikersnaam = txt_gebruikersnaam;
            Wachtwoord = txt_wachtwoord;
            GebruikersId = gebruikersId;
            Vraag = vraag;
            Antwoord = antwoord;
            FunctieId = functieId;
        }

        public string Wachtwoord
        {
            set { wachtwoord = value; }
            get { return wachtwoord; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set
            {
                if (Gebruikersnaam != "")
                {
                    gebruikersnaam = value;
                }
                else
                {
                    throw new Exception($"Fout {value}.. Probeer opnieuw:");
                }
            }
        }

        public int GebruikersId
        {
            get { return gebruikersId; }
            set
            {
                gebruikersId = value;
            }
        }

    }

    public enum FunctieNaam
    {
        Bediening = 1, Kok, Barman, Eigenaar
    }
}
