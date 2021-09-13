using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class CortadoTests
    {
        [TestMethod()]
        public void CortadoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void priceTest()
        {
            //Arrange
            var cort = new Cortado(3, "Espresso");

            //Act
            int price = cort.price();

            //Assert
            Assert.AreEqual(22, price);
        }

        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var cort = new Cortado(2, "Espresso");

            //Act
            string strength = cort.Strength();

            //Assert
            Assert.AreEqual("Medium", strength);
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
            var cortado = new Cortado(6, "Espresso");

            //Act
            var price = cortado.price();

            //Assert
            Assert.Fail();
        }
    }
}