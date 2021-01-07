using System;
using ChapooLogic;
using ChapooModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
            lbl_antwoordVraag.Hide();
            vraag_lbl.Hide();
            btn_enter2.Hide();
            tb_Answer.Hide();
            btn_enter3.Hide();
            tb_NewPassword.Hide();
            nieuwWW_lbl.Hide();
            maakWW_lbl.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_GebruiksN.Text))
            {
                ChapooLogic.Account_Service AccountVraag = new ChapooLogic.Account_Service();
                Account acc = new Account();

                acc.gebruikersnaam = tb_GebruiksN.Text;


                vraag_lbl.Text = "Vraag is: " + AccountVraag.ForgotPassword_vraag(acc);
                if (vraag_lbl.Text == "Vraag is: ")
                {
                    MessageBox.Show("Foute Gebruiksnaam...");
                }
                else
                {
                    vraag_lbl.Show();
                    lbl_antwoordVraag.Show();
                    tb_Answer.Show();
                    btn_enter2.Show();
                }

            }
        }

        private void btn_enter2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Answer.Text))
            {
                ChapooLogic.Account_Service AccountAntwoord = new ChapooLogic.Account_Service();
                Account acc = new Account();

                acc.gebruikersnaam = tb_GebruiksN.Text;

                string Answer = AccountAntwoord.ForgotPassword_antwoord(acc);

                if (tb_Answer.Text.ToLower() == Answer.ToLower())
                {
                    nieuwWW_lbl.Show();
                    maakWW_lbl.Show();
                    tb_NewPassword.Show();
                    btn_enter3.Show();
                }
                else
                {
                    MessageBox.Show("Foute Antwoord op vraag..");
                }

            }
        }

        private void btn_enter3_Click(object sender, EventArgs e)
        {
            ChapooLogic.Account_Service AccountNewPassword = new ChapooLogic.Account_Service();
            Account acc = new Account();

            HashAndSalt hashPassword = new HashAndSalt();
            string salt = hashPassword.CreateSalt(64);
            string hashedWachtwoord = hashPassword.GenerateHash(tb_NewPassword.Text, salt);

            AccountNewPassword.AlterPassword(tb_NewPassword.Text, hashedWachtwoord, salt);

            string gebruikersnaam = tb_GebruiksN.Text;
            string wachtwoord = tb_NewPassword.Text;

            AccountNewPassword.AlterPassword(gebruikersnaam, hashedWachtwoord, salt);

            MessageBox.Show("Wachtwoord is veranderd");
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ForgotPasswordScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
