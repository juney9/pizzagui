using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    class Beverage : MenuItem
    {
        public Beverage(int itemAmount = 0, double itemPrice = 0, string itemName = "", ItemSize itemSize = ItemSize.Medium) 
            : base(itemAmount, itemPrice, itemName, itemSize)
        {
        }

        public override string DisplayString()
        {
            return $"{ItemName} {ItemSize}";
        }
    }
}
