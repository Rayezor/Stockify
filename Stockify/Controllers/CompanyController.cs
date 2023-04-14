using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;

namespace Stockify.Controllers
{
    
    public class CompanyController : Controller
    {
        private static List<Company> companylist = new List<Company>()
        {
            new Company
            {
                CompanyName= "Tesla Inc.",
                StartDate = new DateOnly(2003, 7, 1),
                Employees = 127855,
                Market = "Stock",
                Industry = "Auto Manufacturing",
                Address = "1501 Page Mill Road Palo Alto, CA 94304",
                PhoneNumber = "+1 650-681-5000",
                Headquarters = "California, USA"
            },

            new Company
            {
                CompanyName= "Amazon.com, Inc.",
                StartDate = new DateOnly(1994, 7, 5),
                Employees = 1541000,
                Market = "Stock",
                Industry = "Specialty Distribution",
                Address = "410 Terry Ave N, Seattle 98109, WA",
                PhoneNumber = "(206) 266-1000",
                Headquarters = "Washington, USA"
            },

            new Company
            {
                CompanyName= "Apple Inc.",
                StartDate = new DateOnly(1976, 4, 1),
                Employees = 164000,
                Market = "Stock",
                Industry = "Computer Manufacturing",
                Address = "1 Infinite Loop in Cupertino, California, United States",
                PhoneNumber = "+1 408-996-1010",
                Headquarters = "California, USA"
            },
            new Company
            {
                CompanyName= "A.P. Møller - Mærsk A/Sc",
                StartDate = new DateOnly(2013, 12, 20),
                Employees = 93000,
                Market = "Stock",
                Industry = "Freight Transport",
                Address = "Esplanaden 50, 1098 København K, Denmark",
                PhoneNumber = "+45 33 63 33 63",
                Headquarters = "Copenhagen, Denmark"
            },

           
           

        };



        // GET: CompanyController
        public ActionResult Company()
        {
            return View(companylist);
        }

        // GET: CompanyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyController/Create
        public ActionResult CreateCompany()
        {
            return View();
        }

        // POST: CompanyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCompany(Company collection)
        {
            try
            {


                companylist.Add(collection);


                return RedirectToAction("Company");
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
     

        // GET: CompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
