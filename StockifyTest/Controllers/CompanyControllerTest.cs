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
    public class CompanyControllerTests
    {
        [TestMethod]
        public void Test_Company_Data_not_null()
        {
            var controller = new CompanyController();
            var result = controller.CreateCompany();
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void Test_Company_Data()
        //{
        //    var controller = new CompanyController();
        //    Assert.IsNotInstanceOfType(controller.Company("test"), typeof(Company));

        //}
    }
}