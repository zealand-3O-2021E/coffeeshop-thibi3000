using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class Flat_WhiteTests
    {
        [TestMethod()]
        public void Flat_WhiteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var white = new Flat_White(2, "Espresso");

            //Act
            string strength = white.Strength();

            //Assert
            Assert.AreEqual("Medium", strength);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DiscountTest()
        {
            //Arrange
            var white = new Flat_White(6, "Espresso");

            //Act
            var flat = white.price();

            //Assert
            Assert.Fail();
        }
    }
}