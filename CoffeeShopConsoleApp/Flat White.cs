using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Flat_White : Coffee
    {
        public Flat_White(int discount, string blend) : base(discount, blend)
        {
            
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
