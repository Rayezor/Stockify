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
    public class CompanyTests
    {
        [TestMethod]
        public void ComapnyWithValidInputs()
        {
            Company company = new Company
            {

                CompanyName = "Tesla Inc.",
                StartDate = new DateTime(2003, 7, 1),
                Employees = 127855,
                Market = "Stock",
                Industry = "Auto Manufacturing",
                Address = "1501 Page Mill Road Palo Alto, CA 94304",
                PhoneNumber = "+1 650-681-5000",
                Headquarters = "California, USA"

            };
        }


        [TestMethod]
        public void CompanyWithoutValidInputs()
        {
            Company company = new Company
            {

                CompanyName = "Tesla Inc.",
                StartDate = new DateTime(2003, 7, 1),
                Employees = -12,
                Market = "Stock",
                Industry = "Auto Manufacturing",
                Address = "1501 Page Mill Road Palo Alto, CA 94304",
                PhoneNumber = "+1 650-681-5000",
                Headquarters = "California, USA"

            };
            Assert.IsFalse(company.Employees < 0);
        }

    }
}
