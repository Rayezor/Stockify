using Stockify.Controllers;
using Stockify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockifyTest.Controllers

{
    [TestClass]
    public class CryptoControllerTests
    {
        [TestMethod]
        public void Test_Crypto_Data_not_null()
        {
            var controller = new CryptoController();
            var result = controller.CreateCrypto();
            Assert.IsNotNull(result);
        }

        //    [TestMethod]
        //    public void TestCrypto_Data()
        //    {
        //        var controller = new CryptoController();
        //        Assert.IsNotInstanceOfType(controller.Crypto("test"), typeof(Crypto));

        //    }
        //}
    }
}