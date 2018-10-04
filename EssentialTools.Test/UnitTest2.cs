﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;
using System.Linq;

namespace EssentialTools.Test
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "LifeJacket", Category = "Watersports", Price = 48.95M },
            new Product {Name = "Soccer Ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner Flag", Category = "Soccer", Price = 34/95M }
        };

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            //arrange
            var discounter = new MinnumumDiscountHelper();
            var target = new LinqValueCalculator(discounter);
            var goalTotal = products.Sum(e => e.Price);

            //act
            var result = target.ValueProducts(products);

            //assert
            Assert.AreEqual(goalTotal, result);
        }
    }
}
