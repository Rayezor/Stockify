using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Stockify.Models

namespace StockifyTests
{
    [TestClass]
    public class StockifyTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStockWithInvalidOverdraftLimit()
        {
            Stock acc = new Stock("903509", "12345", -5000);             // -5000 overdraft limit
        }
    }
}
