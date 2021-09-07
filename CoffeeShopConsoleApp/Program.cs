using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(2, "Espresso"),
                new Latte(1, "French Press"),
                new Cortado(3, "AeroPress")

            };

            List<Coffee> coffeeWithMilk = new List<Coffee>()
            {
                new Latte(4, "Espresso"),
                new Cortado(2, "Kalita Wave")
            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price());
                Console.WriteLine("the strength of the coffee is : " + coffee.Strength());
            }


        }
    }
}
