using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    public enum CrustChoice
    {
        Thin,
        Regular,
        Pan
    }
    public enum ItemSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public class MenuItem
    {
        public int ItemAmount { get; set; }
        public double ItemPrice { get; set; }
        public string ItemName { get; set; }
        public ItemSize ItemSize { get; set; }
        public CrustChoice CrustName { get; set; }

        public MenuItem(int itemAmount = 0, double itemPrice = 0, string itemName = "default", ItemSize itemSize = ItemSize.Medium)
        {
            ItemAmount = itemAmount;
            ItemPrice = itemPrice;
            ItemName = itemName;
            ItemSize = itemSize;
            //toppings later
        }
    }
}
