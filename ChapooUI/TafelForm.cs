using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class TafelForm : Form
    {
        public Account Account { get; set; }

        private ChapooLogic.Tafel_Service tafelService;
        private ChapooLogic.Order_Service orderService;

        private MenuForm menu;
        private Tafel tafel;
        private Order order;

        private List<Tafel> tafels;
        private List<Button> buttons;
        public TafelForm()
        {
            InitializeComponent();
            pnlTafel.Hide();

            tafelService = new Tafel_Service();
            orderService = new Order_Service();

            buttons = new List<Button>();
            buttons.Add(btnTafel1);
            buttons.Add(btnTafel2);
            buttons.Add(btnTafel3);
            buttons.Add(btnTafel4);
            buttons.Add(btnTafel5);
            buttons.Add(btnTafel6);
            buttons.Add(btnTafel7);
            buttons.Add(btnTafel8);
            buttons.Add(btnTafel9);
            buttons.Add(btnTafel10);
            TafelStatus();
        }

        private void TafelStatus()
        {
            tafels = tafelService.GetTafelData();

            for (int i = 0; i < tafels.Count; i++)
            {
                if (tafels[i].TafelStatusId == 1)
                {
                    buttons[i].BackColor = Color.LawnGreen;
                }
                else if (tafels[i].TafelStatusId == 2)
                {
                    buttons[i].BackColor = Color.Red;
                }
                else
                {
                    buttons[i].BackColor = Color.Gold;
                }
            }
        }
        private void BtnTafel1_Click(object sender, EventArgs e)
        {
            tafel = tafels[0];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 1:";
            CheckLopend();
        }

        private void BtnTafelPlaatsBestelling_Click(object sender, EventArgs e)
        {
            order = orderService.CreateOrder(tafel, Account);

            tafel.LopendeOrder = false;
            menu = new MenuForm(tafel, Account);

            if (tafel.TafelStatusId != 2)
            {
                tafelService.TafelBezet(tafel.TafelId);
            }

            menu.Order = order;

            if (tafel.TafelStatusId != 2)
            {
                menu.pnlDranken.Visible = true;
            }

            menu.ShowDialog();

            CheckLopend();
        }

        private void BtnReserveerTafel_Click(object sender, EventArgs e)
        {
            if (tafel.TafelStatusId == 1)
            {
                tafelService.BookTafel(tafel.TafelId);
                MessageBox.Show($"Tafel {tafel.TafelId.ToString()} is gereserveerd!");
            }
            else if (tafel.TafelStatusId == 2)
            {
                MessageBox.Show("Tafel is bezet!");
            }
            else
            {
                MessageBox.Show("Tafel is al gereserveerd!");
            }

        }

        private void PnlTafel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTafelTerug_Click(object sender, EventArgs e)
        {
            TafelStatus();
            pnlTafel.Hide();
        }

        private void BtnTafel2_Click(object sender, EventArgs e)
        {
            tafel = tafels[1];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 2:";
            CheckLopend();
        }

        private void BtnTafel3_Click(object sender, EventArgs e)
        {
            tafel = tafels[2];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 3:";
            CheckLopend();
        }

        private void BtnTafel4_Click(object sender, EventArgs e)
        {
            tafel = tafels[3];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 4:";
            CheckLopend();
        }

        private void BtnTafel5_Click(object sender, EventArgs e)
        {
            tafel = tafels[4];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 5:";
            CheckLopend();
        }

        private void BtnTafel6_Click(object sender, EventArgs e)
        {
            tafel = tafels[5];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 6:";
            CheckLopend();
        }

        private void BtnTafel7_Click(object sender, EventArgs e)
        {
            tafel = tafels[6];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 7:";
            CheckLopend();
        }

        private void BtnTafel8_Click(object sender, EventArgs e)
        {
            tafel = tafels[7];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 8:";
            CheckLopend();
        }

        private void BtnTafel9_Click(object sender, EventArgs e)
        {
            tafel = tafels[8];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 9:";
            CheckLopend();
        }

        private void BtnTafel10_Click(object sender, EventArgs e)
        {
            tafel = tafels[9];
            pnlTafel.Show();
            lblTafelNr.Text = "Tafel 10:";
            CheckLopend();
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

        private void CheckLopend()
        {
            if (tafel.LopendeOrder)
            {
                lblLopend.Text = $"(Lopende bestelling voor tafel {tafel.TafelId})";
            }
            else
            {
                lblLopend.Text = $"(Geen lopende bestelling voor tafel {tafel.TafelId})";
            }
        }
    }
}
