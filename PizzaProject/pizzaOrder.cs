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
        private ItemSize pizzaSelected;
        private double pizzaPrice = 0;
        private double toppingPrice = 0;
        private double totalPrice = 0;
        private CrustChoice crustSelected;
        private Dictionary<string, bool> dictToppings = new Dictionary<string, bool>();
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

        private void Carbutton_Click(object sender, EventArgs e)
        {
            Program.CartItems.Add(new MenuItem(1,totalPrice,"Pizza", pizzaSelected, crustSelected));
            richTextBox1.AppendText("Pizza \t " + (totalPrice.ToString()) + "\n" );
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
    }
}
