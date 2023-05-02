using Stockify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stockify.Data.Enums.Category;

namespace StockifyTest.Models
{
    [TestClass]
    public class CryptoTests
    {
        [TestMethod]
        public void CryptoWithValidInputs()
        {
            Crypto crypto = new Crypto { Id = "TSLA", Name = "Bitcoin", Prefix = "BTC", MarketCap = 489.6, Price = 29485, DateCreated = new DateTime(2004, 1, 7), CreatedBy = "Tesla Inc." };
        }

        //[ExpectedException(typeof(Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException))]*/
        [TestMethod]
        public void CryptoWithoutValidInputs()
        {
            Crypto crypto = new Crypto { Id = "TSLA", Name = "Bitcoin", Prefix = "B23423qwew2134e", MarketCap =234.3, Price = 29485, DateCreated = new DateTime(2004, 1, 7), CreatedBy = "Tesla Inc." };
            Assert.AreEqual(crypto.Prefix.Length , 3);
        }


    }
}
