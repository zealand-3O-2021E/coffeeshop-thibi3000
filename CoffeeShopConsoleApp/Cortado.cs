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
            if (Discount <= 5)
            {
                return 25 * Discount;
            }
            else
            {
                throw new Exception("Discount can't be bigger than 5!");
            }        
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }
}
