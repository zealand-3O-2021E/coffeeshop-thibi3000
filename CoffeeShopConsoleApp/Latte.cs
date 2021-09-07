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
            if (Discount <= 5)
            {
                return 40 * Discount;
            }
            else
            {
                throw new Exception("Discount can't be bigger than 5!");
            }
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
