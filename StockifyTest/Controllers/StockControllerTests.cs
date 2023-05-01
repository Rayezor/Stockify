using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host.Mef;
using Xunit;
using Stockify.Controllers;
using Stockify.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace StockifyTest.Controllers

{
    [TestClass]
    public class StockControllerTests
    {
        [TestMethod]
        public void Test_Stock_Data_not_null()
        {
            var controller = new StockController();
            var result = controller.CreateStock();
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void Test_Stock_Data()
        //{
        //    var controller = new StockController();
        //    Assert.IsNotInstanceOfType(controller.Stock("test"), typeof(Stock));

        //}
    }
}