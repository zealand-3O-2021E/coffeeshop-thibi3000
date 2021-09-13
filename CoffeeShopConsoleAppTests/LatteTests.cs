using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void LatteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void priceTest()
        {
            //Arrange
            var latte = new Latte(3, "Espresso");

            //Act
            int price = latte.price();

            //Assert
            Assert.AreEqual(37, price);
        }

        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var latte = new Latte(2, "Espresso");

            //Act
            string strength = latte.Strength();

            //Assert
            Assert.AreEqual("Weak", strength);
        }

        [TestMethod()]
        public void MlMilkTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DiscountTest()
        {
            //Arrange
            var latte = new Latte(6, "Espresso");

            //Act
            var price = latte.price();

            //Assert
            Assert.Fail();
        }
    }
}