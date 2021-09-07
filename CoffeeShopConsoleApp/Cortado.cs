using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, IMilk
    {       

        public Cortado(int discount, string blend) : base(discount, blend)
        {

        }

        public override int price()
        {           
                return 25 - base.Discount;                 
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int MlMilk()
        {
            return 40;
        }
    }
}
