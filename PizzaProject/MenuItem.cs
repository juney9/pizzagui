using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
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
        public virtual string DisplayString() 
        {
            return $"{ItemName}";
        }

        public MenuItem(int itemAmount = 0, double itemPrice = 0, string itemName = "", ItemSize itemSize = ItemSize.Medium)
        {
            ItemAmount = itemAmount;
            ItemPrice = itemPrice;
            ItemName = itemName;
            ItemSize = itemSize;
            //toppings later
        }

        public virtual Dictionary<string, bool> DisplayChildrenStrings()
        {
            return null;
        }
    }
}
