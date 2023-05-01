using static Stockify.Data.Enums.Category;
using Stockify.Models;

namespace StockifyTest.Models
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void StockWithValidInputs()
        {
            Stock stock = new Stock
            {
                Id = "MAERSK-B.CO",
                Name = "A.P. Møller - Mærsk A/S",
                Category = Categories.Industrials,
                MarketCap = 212.814,
                Price = 11470.00,
                EPS = 10846.03,
                Exchange = "OMX",
                CompanyId = "Maersk"
            };
        }


        [TestMethod]
        public void StockWithoutValidInputs()
        {
            Stock stock = new Stock
            {
                Id = "MAERSK-B.CO",
                Name = "A.P. Møller - Mærsk A/S",
                Category = Categories.Industrials,
                MarketCap = 212.814,
                Price = -1143212370.00,
                EPS = 10846.03,
                Exchange = "OMX",
                CompanyId = "Maersk"
            };
            Assert.IsFalse(stock.Price < 0);
        }

    }
}