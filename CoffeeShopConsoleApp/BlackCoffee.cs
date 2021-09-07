using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {       

        public BlackCoffee(int discount, string blend) : base(discount, blend)
        {

        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
