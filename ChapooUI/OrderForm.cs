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
    public partial class OrderForm : Form
    {
        public Order Order { get; set; }

        private Tafel tafel;
        private Account account;

        private OrderItem_Service orderItem_Service;
        private MenuItem_Service menuItem_Service;
        private Order_Service order_Service;
        private List<OrderItem> orderItems;
        private List<ChapooModel.MenuItem> menuItems;

        decimal totaalPrijs = 0;

        public OrderForm(Tafel tafel, Account account)
        {
            InitializeComponent();

            this.tafel = tafel;
            this.account = account;

            orderItem_Service = new OrderItem_Service();
            menuItem_Service = new MenuItem_Service();
            order_Service = new Order_Service();
        }
        public void CheckOrder()
        {
            int orderId = Order.OrderId;
            lblOrderId.Text = orderId.ToString();

            orderItems = orderItem_Service.GetOrderItems(orderId);
            menuItems = new List<ChapooModel.MenuItem>();

            foreach (OrderItem orderItem in orderItems)
            {
                menuItems.Add(menuItem_Service.GetMenuItemsSpecific(orderItem.MenuItemId));
            }

            listviewOrderItems.Items.Clear();

            for (int i = 0; i < orderItems.Count; i++)
            {
                decimal prijs = menuItems[i].Prijs * (decimal)orderItems[i].Aantal;

                ListViewItem li = new ListViewItem(menuItems[i].MenuItemNaam.ToString());
                li.SubItems.Add($"{orderItems[i].Aantal.ToString()}x");
                li.SubItems.Add($"{menuItems[i].Prijs.ToString("€0.00")}");
                listviewOrderItems.Items.Add(li);

                totaalPrijs += prijs;
            }

            lblTotaalprijs.Text = totaalPrijs.ToString("€0.00");
        }

        private void BtnBevestigOrder_Click(object sender, EventArgs e)
        {
            Order.TotaalPrijs = totaalPrijs;
            Order.Opmerking = txtOpmerking.Text;

            order_Service.UpdateOrder(Order);

            listViewPopUp.Items.Clear();

            for (int i = 0; i < orderItems.Count; i++)
            {
                menuItem_Service.UpdateVoorraad(menuItems[i], orderItems[i]);

                ListViewItem li = new ListViewItem(menuItems[i].MenuItemNaam);
                li.SubItems.Add($"{orderItems[i].Aantal.ToString()}x");
                listViewPopUp.Items.Add(li);
            }

            lblOpmerking.Text = Order.Opmerking;
            lblAangemaaktDoor.Text = $"Aangemaakt door: {account.Gebruikersnaam.ToUpper()}";

            pnlPopUp.Visible = true;
            btnBevestigOrder.Visible = false;
            btnOrderFormTerug.Visible = false;
        }

        private void BtnOrderFormTerug_Click(object sender, EventArgs e)
        {
            pnlWijzigOrder.Visible = true;
            FillListviewWijzig();
        }

        private void BtnBevestigOK_Click(object sender, EventArgs e)
        {
            pnlPopUp.Visible = false;
            tafel.LopendeOrder = true;
            this.Close();
        }

        private void BtnVerwijderItem_Click(object sender, EventArgs e)
        {
            orderItem_Service.RemoveOrderItem(int.Parse(listViewWijzigOrder.SelectedItems[0].ToString().Substring(15, 3)));

            totaalPrijs = 0;
            CheckOrder();

            FillListviewWijzig();
        }

        private void BtnWijzigPlus_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(lblWijzigAantal.Text);
            aantal++;
            lblWijzigAantal.Text = aantal.ToString();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(lblWijzigAantal.Text);
            aantal--;
            lblWijzigAantal.Text = aantal.ToString();
        }

        private void BtnWijzigAantal_Click(object sender, EventArgs e)
        {
            int wijzigAantal = int.Parse(lblWijzigAantal.Text);

            orderItem_Service.EditOrderItem(int.Parse(listViewWijzigOrder.SelectedItems[0].ToString().Substring(15, 3)), wijzigAantal);
            orderItem_Service.GetOrderItems(Order.OrderId);
            totaalPrijs = 0;
            CheckOrder();

            FillListviewWijzig();

            lblWijzigAantal.Text = 0.ToString();
        }

        private void BtnBevestigWijziging_Click(object sender, EventArgs e)
        {
            pnlWijzigOrder.Visible = false;
        }

        private void FillListviewWijzig()
        {
            listViewWijzigOrder.Items.Clear();

            for (int i = 0; i < orderItems.Count; i++)
            {
                ListViewItem li = new ListViewItem(orderItems[i].OrderItemId.ToString("000"));
                li.SubItems.Add(menuItems[i].MenuItemNaam.ToString());
                li.SubItems.Add($"{orderItems[i].Aantal.ToString()}x");
                listViewWijzigOrder.Items.Add(li);
            }
        }
    }
}
