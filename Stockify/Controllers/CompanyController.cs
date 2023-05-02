using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;
using Stockify.Data;
using System.Net;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
        
        // GET: CompanyController
        public ActionResult Company(string searchString)
        {
            // Count how many companies exist in the database
            ViewBag.Amount = stockifyDB.Companies.Count().ToString();
            
            // variable with all companies
            var companies = from s in stockifyDB.Companies.Include(n => n.Stock)
                            select s;
            //  look for existing company based on search input
            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies.Where(s => s.CompanyName.Contains(searchString));
            }

            // return search results to the user
            return View(companies);
        }

        // GET: CompanyController/Details
        public ActionResult Details(string id)
        {
            Company found = stockifyDB.Companies.FirstOrDefault(p => p.Id == id);
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

        // GET: CompanyController/Edit
        public ActionResult Edit(string id)
        {
            var found = stockifyDB.Companies.Where(c => c.Id == id).FirstOrDefault();
            return View(found);
        }

        // POST: CompanyController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                Company company = stockifyDB.Companies.FirstOrDefault(p => p.Id == id);
                company.CompanyName = collection["CompanyName"];
                company.Employees = int.Parse(collection["Employees"]);
                company.Market = collection["Market"];
                company.Industry =collection["Industry"];
                company.Address = collection["Address"];
                company.PhoneNumber = collection["PhoneNumber"];
                company.Headquarters = collection["Headquarters"];
                company.StockId = collection["StockId"];
                
                stockifyDB.SaveChanges();
                return RedirectToAction("Company");
            }
            catch
            {
                return View(id);
            }
        }


        // GET: CompanyController/Delete
        public ActionResult DeleteCompany(string id)
        {
            var company = stockifyDB.Companies.Include(n => n.Stock).Where(c => c.Id == id).FirstOrDefault();
            return View(company);
        }

        // POST: StockController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCompany(string id, IFormCollection companycollection)
        {
            try
            {
                var company = stockifyDB.Companies.Include(n=>n.Stock).Where(c => c.Id == id).FirstOrDefault();
                stockifyDB.Companies.Remove(company);
                stockifyDB.SaveChanges();
                
                return RedirectToAction("Company");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
