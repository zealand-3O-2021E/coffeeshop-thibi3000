using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class BlackCoffeeTests
    {
        [TestMethod()]
        public void BlackCoffeeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var black = new BlackCoffee(2, "Espresso");

            //Act
            string strength = black.Strength();

            //Assert
            Assert.AreEqual("Strong", strength);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DiscountTest()
        {
            //Arrange
            var black = new BlackCoffee(6, "Espresso");

            //Act
            var flat = black.price();

            //Assert
            Assert.Fail();
        }
    }
}