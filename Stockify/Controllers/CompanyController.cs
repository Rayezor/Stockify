using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;
using Stockify.Data;
using System.Net;
using Microsoft.Data.SqlClient;

namespace Stockify.Controllers
{
    
    public class CompanyController : Controller
    {
        private StockifyContext stockifyDB;
        public CompanyController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated(); 
             
        }
        //private static List<Company> companylist = new List<Company>()
        //{
        //    new Company
        //    {
        //        CompanyName= "Tesla Inc.",
        //        StartDate = new DateTime(2003, 7, 1),
        //        Employees = 127855,
        //        Market = "Stock",
        //        Industry = "Auto Manufacturing",
        //        Address = "1501 Page Mill Road Palo Alto, CA 94304",
        //        PhoneNumber = "+1 650-681-5000",
        //        Headquarters = "California, USA"
        //    },

        //    new Company
        //    {
        //        CompanyName= "Amazon.com, Inc.",
        //        StartDate = new DateTime(1994, 7, 5),
        //        Employees = 1541000,
        //        Market = "Stock",
        //        Industry = "Specialty Distribution",
        //        Address = "410 Terry Ave N, Seattle 98109, WA",
        //        PhoneNumber = "(206) 266-1000",
        //        Headquarters = "Washington, USA"
        //    },

        //    new Company
        //    {
        //        CompanyName= "Apple Inc.",
        //        StartDate = new DateTime(1976, 4, 1),
        //        Employees = 164000,
        //        Market = "Stock",
        //        Industry = "Computer Manufacturing",
        //        Address = "1 Infinite Loop in Cupertino, California, United States",
        //        PhoneNumber = "+1 408-996-1010",
        //        Headquarters = "California, USA"
        //    },
        //    new Company
        //    {
        //        CompanyName= "A.P. Møller - Mærsk A/Sc",
        //        StartDate = new DateTime(2013, 12, 20),
        //        Employees = 93000,
        //        Market = "Stock",
        //        Industry = "Freight Transport",
        //        Address = "Esplanaden 50, 1098 København K, Denmark",
        //        PhoneNumber = "+45 33 63 33 63",
        //        Headquarters = "Copenhagen, Denmark"
        //    },

           
           

        //};



        // GET: CompanyController
        public ActionResult Company(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var companies = from s in stockifyDB.Companies
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies.Where(s => s.CompanyName.Contains(searchString)
                                       /*|| s.FirstMidName.Contains(searchString)*/);
            }
            switch (sortOrder)
            {
                case "name_desc":
                    companies = companies.OrderByDescending(s => s.CompanyName);
                    break;
                case "Date":
                    companies = companies.OrderBy(s => s.StartDate);
                    break;
                case "date_desc":
                    companies = companies.OrderByDescending(s => s.StartDate);
                    break;
                default:
                    companies = companies.OrderBy(s => s.CompanyName);
                    break;
            }
            return View(stockifyDB.Companies.OrderBy(p => p.CompanyName).ToList());
        }

        // GET: CompanyController/Details/5
        public ActionResult Details(string id)
        {
            Company found = stockifyDB.Companies.FirstOrDefault(p => p.CompanyName.ToLower().Equals(id.ToLower()));
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Company");
            }
            ;
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


                stockifyDB.Companies.Add(collection);
                stockifyDB.SaveChanges();


                return RedirectToAction("Company");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: CompanyController/Edit/5
        public ActionResult Edit(string id)
        {
            Company found = stockifyDB.Companies.FirstOrDefault(p => p.CompanyName.ToLower().Equals(id.ToLower()));
            return View(found);
        }

        // POST: CompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                Company company = stockifyDB.Companies.FirstOrDefault(p => p.CompanyName.Equals(id));
                company.StartDate = DateTime.Parse(collection["StartDate"]);
                company.Employees = int.Parse(collection["Employees"]);
                company.Market = collection["Market"];
                company.Industry =collection["Industry"];
                company.Address = collection["Address"];
                company.PhoneNumber = collection["PhoneNUmber"];
                company.Headquarters = collection["Headquarters"];
                stockifyDB.SaveChanges();
                return RedirectToAction("Company");
            }
            catch
            {
                return View(id);
            }
        }


        // GET: CompanyController/Delete/5
        public ActionResult Delete(string id)
        {
            Company found = stockifyDB.Companies.FirstOrDefault(p => p.CompanyName.ToLower().Equals(id.ToLower()));
            return View(found);
        }

        // POST: StockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Company collection)
        {
            try
            {
                Company found = stockifyDB.Companies.FirstOrDefault(p => p.CompanyName.ToLower().Equals(id.ToLower()));
                stockifyDB.Companies.Remove(found);
                return RedirectToAction("Company");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
