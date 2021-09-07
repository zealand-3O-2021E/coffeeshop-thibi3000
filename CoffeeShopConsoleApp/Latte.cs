using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte : Coffee, IMilk
    {       

        public Latte(int discount, string blend) : base(discount, blend)
        {

        }

        public override int price()
        {           
                return 40 - base.Discount;           
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }
    }
}
