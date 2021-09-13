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
            if (discount > 5)
                throw new ArgumentException("Not more than 5 discount");

            if (discount < 0)
                throw new ArgumentException("Not less than 0 discount");
            
            Discount = discount;
            Blend = blend;
        }
            

        public abstract string Strength();
        
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()//virtual zodat we ze kunnen overschrijven
        {          
                return 20 - Discount;           
        }



    }
}
