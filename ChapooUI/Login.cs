using System;
using ChapooModel;
using ChapooLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ChapooLogic.Account_Service service = new ChapooLogic.Account_Service();
            ChapooLogic.Functie_Service functieService = new ChapooLogic.Functie_Service();
            Account huidigGebruiker = new Account();
            huidigGebruiker.Gebruikersnaam = txtbox_Gebruikersnaam.Text;
            string salt = service.GetSalt(huidigGebruiker);

            HashAndSalt retrieve = new HashAndSalt();
            string hash = retrieve.GenerateHash(txtbox_Wachtwoord.Text, salt);

            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=chapoo1920f04;Persist Security Info=True;User ID=chapoo1920f04;Password=Eo9G2f?Fz!b6");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Gebruiker WHERE Gebruikersnaam ='" + txtbox_Gebruikersnaam.Text + "' AND Hash ='" + hash + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                int functieNr = functieService.GetFunctie(huidigGebruiker);
                MessageBox.Show($"Welkom {huidigGebruiker.Gebruikersnaam.ToUpper()}\n\nU bent ingelogd met functie: {(FunctieNaam)functieNr}");

                this.Hide();

                if (functieNr == 1)
                {
                    TafelForm tafelOverzicht = new TafelForm();
                    tafelOverzicht.Account = huidigGebruiker;
                    tafelOverzicht.Show();
                }
                else if(functieNr == 2)
                {
                    KeukenForm keukenOverzicht = new KeukenForm();
                    keukenOverzicht.Show();
                }
                else if(functieNr == 3)
                {
                    BarForm barOverzicht = new BarForm();
                    barOverzicht.Show();
                }
                else
                {
                    MessageBox.Show("Geen functie gevonden.");
                }
            }
            else
            {
                MessageBox.Show("Foute gebruikersnaam en/of wachtwoord..");
            }
        }

        private void btn_wachtwoordVergeten_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordScreen forgotPasswordScreen = new ForgotPasswordScreen();
            forgotPasswordScreen.Show();
        }

        private void Txtbox_Wachtwoord_TextChanged(object sender, EventArgs e)
        {
            txtbox_Wachtwoord.PasswordChar = '*';
            txtbox_Wachtwoord.CharacterCasing = CharacterCasing.Lower;
            txtbox_Wachtwoord.TextAlign = HorizontalAlignment.Left;
        }
    }
}
