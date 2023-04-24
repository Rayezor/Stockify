using Microsoft.AspNetCore.Mvc;
using Stockify.Controllers;
using Stockify.Models;

namespace StockifyUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Stock_ReturnsViewName()
        {
            var controller = new StockController();
            var result = controller.Stock() as ViewResult;
            Assert.Equal("Stock", result?.ViewName);
        }
        [Fact]
        public void Test_Stock_ReturnsViewData()
        {
            var controller = new StockController();
            var result = controller.Stock() as ViewResult;
            var stock = (Stock?)result?.ViewData.Model;
            Assert.Null(stock);

        }
    }
}