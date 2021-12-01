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
    public partial class pizzaOrder : Form
    {
        public static pizzaOrder pizzaOrderForm = new pizzaOrder();
        private ItemSize pizzaSelected;
        private double pizzaPrice = 6;
        private double toppingPrice = 0;
        private double totalPrice = 0;
        private CrustChoice crustSelected;
        private Dictionary<string, bool> dictToppings = new Dictionary<string, bool>();
        private List<MenuItem> beverages = new List<MenuItem>();
        private int cookieCount = 0;
        private int breadStickCount = 0;
        private int breadStickBiteCount = 0;

        public pizzaOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToppingsChanged(object sender, EventArgs e)
        {
            dictToppings[(sender as CheckBox).Text] = (sender as CheckBox).Checked;
            calculatePrice();         
        }

        private void AddPizza_Click(object sender, EventArgs e)
        {
            Program.CartItems.Add(new Pizza(1,totalPrice,"Pizza ", pizzaSelected, crustSelected, dictToppings));
            richTextBox1.AppendText($"Pizza {pizzaSelected.ToString()} {crustSelected.ToString()} \t ${totalPrice.ToString()} \n" );
            var listOfToppings = dictToppings.Where(kv => kv.Value == true).ToList();
            foreach(var topping in listOfToppings)
            {
                richTextBox1.AppendText("    " + topping.Key + "\n");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PizzaSizeButton_Changed(object sender, EventArgs e)
        {
            switch((sender as RadioButton).Tag)
            {
                case "Small":
                    pizzaSelected = ItemSize.Small;
                    pizzaPrice = Properties.Settings.Default.SmallPizzaPrice;
                    toppingPrice = Properties.Settings.Default.SmallToppingPrice;
                    break;
                case "Medium":
                    pizzaSelected = ItemSize.Medium;
                    pizzaPrice = Properties.Settings.Default.MediumPizzaPrice;
                    toppingPrice = Properties.Settings.Default.MediumToppingPrice;
                    break;
                case "Large":
                    pizzaSelected = ItemSize.Large;
                    pizzaPrice = Properties.Settings.Default.LargePizzaPrice;
                    toppingPrice = Properties.Settings.Default.LargeToppingPrice;
                    break;
                case "X-Large":
                    pizzaSelected = ItemSize.ExtraLarge;
                    pizzaPrice = Properties.Settings.Default.ExtraLargePizzaPrice;
                    toppingPrice = Properties.Settings.Default.ExtraLargeToppingPrice;
                    break;
            }
            calculatePrice();
        }

        private void calculatePrice()
        {
            var listOfToppings = dictToppings.Where(kv => kv.Value == true).ToList();
            double totalToppingPrice = 0;
            if (listOfToppings.Count > 1)
            {
                totalToppingPrice = listOfToppings.Count * toppingPrice - toppingPrice;
            }
            totalPrice = totalToppingPrice + pizzaPrice;
        }

        private void CrustButton_Changed(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Text)
            {
                case "Thin":
                    crustSelected = CrustChoice.Thin;
                    break;
                case "Regular":
                    crustSelected = CrustChoice.Regular;
                    break;
                case "Pan":
                    crustSelected = CrustChoice.Pan;
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BeverageSmall_ValueChanged(object sender, EventArgs e)
        {
            var count = ((int)(sender as NumericUpDown).Value);
            var item = beverages.Where(b => b.ItemName == (sender as NumericUpDown).Tag as string && b.ItemSize == ItemSize.Small).FirstOrDefault();
            if (item == null)
            {
                beverages.Add(new Beverage(count, Properties.Settings.Default.BeveragePrice, (sender as NumericUpDown).Tag as string,
                    ItemSize.Small));
            }
            else
            {
                if (count == 0)
                {
                    beverages.Remove(item);
                }
                else
                {
                    item.ItemAmount = count;
                }
            }
        }

        private void BeverageMedium_ValueChanged(object sender, EventArgs e)
        {
            var count = ((int)(sender as NumericUpDown).Value);

            var item = beverages.Where(b => b.ItemName == (sender as NumericUpDown).Tag as string && b.ItemSize == ItemSize.Medium).FirstOrDefault();
            if (item == null)
            {
                beverages.Add(new Beverage(count, Properties.Settings.Default.BeveragePrice, (sender as NumericUpDown).Tag as string,
                    ItemSize.Medium));
            }
            else
            {
                if (count == 0)
                {
                    beverages.Remove(item);
                }
                else
                {
                    item.ItemAmount = count;
                }
            }
        }

        private void BeverageLarge_ValueChanged(object sender, EventArgs e)
        {
            var count = ((int)(sender as NumericUpDown).Value);

            var item = beverages.Where(b => b.ItemName == (sender as NumericUpDown).Tag as string && b.ItemSize == ItemSize.Large).FirstOrDefault();
            if (item == null)
            {
                beverages.Add(new Beverage(count, Properties.Settings.Default.BeveragePrice, (sender as NumericUpDown).Tag as string,
                    ItemSize.Large));
            }
            else
            {
                if (count == 0)
                {
                    beverages.Remove(item);
                }
                else
                {
                    item.ItemAmount = count;
                }
            }
        }

        private void AddBeverage_Click_1(object sender, EventArgs e)
        {
            double price = 0;
            foreach (var beverage in beverages)
            {
                price = beverage.ItemPrice * beverage.ItemAmount;
                Program.CartItems.Add(new Beverage(beverage.ItemAmount, price, beverage.ItemName, beverage.ItemSize));
                richTextBox1.AppendText($"{beverage.ItemName} {beverage.ItemSize.ToString()} Qty: {beverage.ItemAmount} \t ${price} \n");
            }
        }

        private void AddSides(object sender, EventArgs e)
        {
            if (cookieCount > 0)
            {
                Program.CartItems.Add(new MenuItem(cookieCount, Properties.Settings.Default.CookiePrice * cookieCount, "Cookie", ItemSize.Medium));
                richTextBox1.AppendText($"Cookie  Qty: {cookieCount} \t ${Properties.Settings.Default.CookiePrice * cookieCount} \n");
            }

            if (breadStickCount > 0)
            {
                Program.CartItems.Add(new MenuItem(breadStickCount, Properties.Settings.Default.BreadsticksPrice * breadStickCount, "Breadstick", ItemSize.Medium));
                richTextBox1.AppendText($"Breadstick  Qty: {breadStickCount} \t ${Properties.Settings.Default.BreadsticksPrice * breadStickCount} \n");
            }

            if (breadStickBiteCount > 0)
            {
                Program.CartItems.Add(new MenuItem(breadStickBiteCount, Properties.Settings.Default.BreadstickBitesPrice *breadStickBiteCount, "Breadstick Bite", ItemSize.Medium));
                richTextBox1.AppendText($"Breadstick Bite  Qty: {breadStickBiteCount} \t ${Properties.Settings.Default.BreadstickBitesPrice * breadStickBiteCount} \n");
            }
        }

        private void CookieChange(object sender, EventArgs e)
        {
            cookieCount = (int)(sender as NumericUpDown).Value;
        }

        private void BreadStickChange(object sender, EventArgs e)
        {
            breadStickCount = (int)(sender as NumericUpDown).Value;
        }

        private void BreadStickBiteChange(object sender, EventArgs e)
        {
            breadStickBiteCount = (int)(sender as NumericUpDown).Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkout.checkoutForm.Init();
            checkout.checkoutForm.Show();
        }
    }
}
