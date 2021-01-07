using System;
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
    public partial class BarForm : Form
    {
        public BarForm()
        {
            InitializeComponent();
        }

        private void BtnTerugNaarMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();

                this.Close();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
