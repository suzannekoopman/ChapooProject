using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;

namespace ChapooUI
{
    public partial class MenuForm : Form
    {
        public Order Order { get; set; }

        private ChapooLogic.OrderItem_Service orderItemService;
        private ChapooLogic.MenuItem_Service menuItem_Service;
        private List<ChapooModel.MenuItem> menuItems;

        private OrderForm orderForm;

        public MenuForm(Tafel tafel, Account account)
        {
            InitializeComponent();

            menuItem_Service = new MenuItem_Service();
            orderForm = new OrderForm(tafel, account);
            menuItems = menuItem_Service.GetMenuListViewItems();
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            pnlLunch.Visible = true;
        }

        private void BtnLunchHoofdgerecht_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Hoofdgerechten: ";

            FillListview(2);
        }

        private void BtnLunchNagerecht_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Nagerechten: ";

            FillListview(3);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnlLunch.Visible = false;
        }

        private void BtnLunchVoorgerecht_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Voorgerechten: ";

            FillListview(1);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = false;
            pnlLunch.Visible = false;
        }


        private void BtnVoegToeLunchVoor_Click(object sender, EventArgs e)
        {
            orderItemService = new OrderItem_Service();
            ChapooModel.OrderItem orderItem = new OrderItem();

            orderItem.MenuItemId = int.Parse(listviewMenuItems.SelectedItems[0].ToString().Substring(15, 2));
            orderItem.Aantal = int.Parse(lblAantal.Text);
            orderItem.OrderStatusId = 1;
            orderItem.Order = Order;

            if (orderItem.Aantal > 0)
            {
                if (menuItems[orderItem.MenuItemId - 1].Voorraad >= orderItem.Aantal)
                {
                    orderItemService.CreateOrderItem(orderItem);
                    MessageBox.Show("Item(s) toegevoegd aan bestelling!");
                }
                else
                {
                    MessageBox.Show("Niet genoeg voorraad!");
                }
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
            lblAantal.Text = 0.ToString();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnTerugNaarTafel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMenuBekijkBestelling_Click(object sender, EventArgs e)
        {
            orderForm.ShowDialog();
        }

        private void BtnDinerVoor_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Voorgerechten: ";

            FillListview(4);
        }

        private void BtnDinerTussen_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Tussengerechten: ";

            FillListview(5);
        }

        private void BtnDinerHoofd_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Hoofdgerechten: ";

            FillListview(6);
        }

        private void BtnDinerNa_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlLunch.Visible = false;
            pnlDiner.Visible = false;

            lblMenuText.Text = "Nagerechten: ";

            FillListview(7);
        }

        private void BtnDinerTerug_Click(object sender, EventArgs e)
        {
            pnlDiner.Visible = false;
        }

        private void BtnDiner_Click(object sender, EventArgs e)
        {
            pnlDiner.Visible = true;
        }

        private void BtnDrank_Click(object sender, EventArgs e)
        {
            pnlDranken.Visible = true;
        }

        private void BtnFrisdrank_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlDranken.Visible = false;

            lblMenuText.Text = "Frisdranken: ";

            FillListview(8);
        }

        private void BtnBieren_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlDranken.Visible = false;

            lblMenuText.Text = "Bieren van de tap: ";

            FillListview(9);
        }

        private void BtnWijnen_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlDranken.Visible = false;

            lblMenuText.Text = "Wijnen: ";

            FillListview(10);
        }

        private void BtnGedistilleerd_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlDranken.Visible = false;

            lblMenuText.Text = "Gedistilleerde dranken: ";

            FillListview(11);
        }

        private void BtnKoffieThee_Click(object sender, EventArgs e)
        {
            pnlMenuListView.Visible = true;
            pnlDranken.Visible = false;

            lblMenuText.Text = "Koffie/Thee: ";

            FillListview(12);
        }

        private void BtnDrankTerug_Click(object sender, EventArgs e)
        {
            pnlDranken.Visible = false;
        }

        private void BtnMenuListBekijkOrder_Click(object sender, EventArgs e)
        {
            orderForm.Order = Order;
            orderForm.CheckOrder();
            orderForm.ShowDialog();

            pnlMenuListView.Visible = false;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            int intLblAantal = int.Parse(lblAantal.Text);
            intLblAantal++;
            lblAantal.Text = intLblAantal.ToString();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            int intLblAantal = int.Parse(lblAantal.Text);
            if (intLblAantal > 0)
            {
                intLblAantal--;
                lblAantal.Text = intLblAantal.ToString();
            }
        }

        private void FillListview(int catId)
        {
            listviewMenuItems.Items.Clear();

            foreach (ChapooModel.MenuItem menuItem in menuItems)
            {
                if (menuItem.CategorieId == catId)
                {
                    ListViewItem li = new ListViewItem(menuItem.MenuItemId.ToString("00"));
                    li.SubItems.Add(menuItem.MenuItemNaam);
                    li.SubItems.Add(menuItem.Voorraad.ToString());
                    listviewMenuItems.Items.Add(li);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
