using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    public enum CrustChoice
    {
        Pan,
        Regular,
        Thin
    }

    public class Pizza : MenuItem
    {
        private Dictionary<string, bool> _dictToppings = new Dictionary<string, bool>();
        public Pizza(int itemAmount = 0, double itemPrice = 0,
            string itemName = "default",
            ItemSize itemSize = ItemSize.Medium,
            CrustChoice crust = CrustChoice.Regular,
            Dictionary<string, bool> dictToppings = null)
            : base(itemAmount, itemPrice, itemName, itemSize)
        {
            _dictToppings = dictToppings;
            CrustName = crust;
        }

        public CrustChoice CrustName { get; set; }
        public override string DisplayString()
        {
            return $"{ItemName} {CrustName} {ItemSize}";
        }
        public override Dictionary<string, bool> DisplayChildrenStrings()
        {
            return _dictToppings;
        }
    }
}
