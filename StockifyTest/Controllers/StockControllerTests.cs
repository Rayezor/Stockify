//using Microsoft.AspNetCore.Mvc;
//using Microsoft.CodeAnalysis.Host.Mef;
//using Xunit;
//using Stockify.Controllers;
//using Stockify.Models;

//namespace StockifyTest.Controllers

//{
//    [TestClass]
//    public class StockControllerTests
//    {
//        [TestMethod]
//        public void Test_Stock_ReturnsViewName()
//        {
//            var controller = new StockController();
//            var result = controller.Stock() as ViewResult;
//            Assert.AreEqual("Stock", result?.ViewName);
//        }
//        /*[TestMethod]
//        public void Test_Stock_ReturnsViewData()
//        {
//            var controller = new StockController();
//            var result = controller.Stock() as ViewResult;
//            var stock = (List<Stock>?)result?.ViewData.Model;
//            Assert.IsNull(stock);
//        }*/
//    }
//}