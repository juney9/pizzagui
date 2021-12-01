using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class receipt : Form
    {
        public static receipt receiptForm = new receipt();
        public receipt()
        {
            InitializeComponent();

            listView1.Items.Clear();
            double totalPrice = 0;
            foreach (var cartItem in Program.CartItems)
            {
                totalPrice += cartItem.ItemPrice;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(cartItem.ItemAmount.ToString());
                item.SubItems.Add('$' + cartItem.ItemPrice.ToString());
                item.Text = cartItem.DisplayString();
                listView1.Items.Add(item);
                var children = cartItem.DisplayChildrenStrings();
                if (children != null)
                {
                    foreach (var kv in children)
                    {
                        if (kv.Value)
                        {
                            ListViewItem itemChild = new ListViewItem();
                            itemChild.Text = "   " + kv.Key;
                            listView1.Items.Add(itemChild);

                        }
                    }
                }
            }

            ListViewItem itemSpace = new ListViewItem();
            itemSpace.Text = "--------------------------------------";
            itemSpace.SubItems.Add("----------------------");
            itemSpace.SubItems.Add("------------------------");
            listView1.Items.Add(itemSpace);

            ListViewItem subTotal = new ListViewItem();
            subTotal.Text = "Sub total";
            subTotal.SubItems.Add("");
            subTotal.SubItems.Add('$' + totalPrice.ToString());
            listView1.Items.Add(subTotal);

            ListViewItem Tax = new ListViewItem();
            Tax.Text = "Tax";
            Tax.SubItems.Add("");
            Tax.SubItems.Add('$' + Math.Round((totalPrice * .06),2).ToString());
            listView1.Items.Add(Tax);

            ListViewItem itemTotal = new ListViewItem();
            itemTotal.Text = "Total";
            itemTotal.SubItems.Add("");
            itemTotal.SubItems.Add('$' + Math.Round((totalPrice * 1.06),2).ToString());
            listView1.Items.Add(itemTotal);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            Program.CartItems.Clear();
            pizzaOrder.pizzaOrderForm.Close();
            checkout.checkoutForm.Close();
            pizzaOrder.pizzaOrderForm = new pizzaOrder();
            checkout.checkoutForm = new checkout();
            receipt.receiptForm = new receipt();
            this.Hide();
            pizzaOrder.pizzaOrderForm.Show();
        }
    }
}
