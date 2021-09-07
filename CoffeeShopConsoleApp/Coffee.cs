using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public int Discount { get; set; }
        public string Blend { get; set; }

        public Coffee(int discount, string blend)
        {
            Discount = discount;
            Blend = blend;
        }

        public abstract string Strength();
        
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            if (Discount <= 5)
            {
                return 20 * Discount;
            }
            else
            {
                throw new Exception("Discount can't be bigger than 5!");
            }

        }



    }
}
