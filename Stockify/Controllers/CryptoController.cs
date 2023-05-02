using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class CryptoController : Controller
    {


        private StockifyContext stockifyDB;
        public CryptoController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }


        public ActionResult Crypto(string searchString)
        {
            var allCryptos = from s in stockifyDB.Cryptos.Include(n => n.Company)
                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                allCryptos = allCryptos.Where(s => s.Name.Contains(searchString));
            }
            return View(allCryptos);
        }


        // GET: CryptoController/Details
        public ActionResult CryptoDetails(string id)
        {
            Crypto found = stockifyDB.Cryptos.FirstOrDefault(p => p.Id.Equals(id));
            if (found != null)
            {
                // Use Viewbag to generate list of all companies
                ViewBag.Companylist = stockifyDB.Companies.ToList();
                ViewBag.CurrentCrypto = found.CreatedBy;
                return View(found);
            }
            else
            {
                return RedirectToAction("Crypto");
            }
        }


        public ActionResult CreateCrypto()
        {
            return View();
        }


        // GET: CryptoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCrypto(Crypto newcrypto)
        {
            if (ModelState.IsValid)
            {

                // set date and time to when created and hide from page view 
                newcrypto.DateCreated = DateTime.Now;
                stockifyDB.Cryptos.Add(newcrypto);
                stockifyDB.SaveChanges();
                return RedirectToAction("Crypto");

            }
            else
            {
                return View();
            }

        }


        // GET: CryptoController/Edit
        public ActionResult EditCrypto(string id)
        {
            var crypt = stockifyDB.Cryptos.Where(c => c.Id == id).FirstOrDefault();
            return View(crypt);
        }


        //POST: CryptoController/Edit
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult EditCrypto(string Id, IFormCollection cyyptocollection)
        {
            try
            {
                Crypto editcyrpto = stockifyDB.Cryptos.FirstOrDefault(p => p.Id.Equals(Id));
                editcyrpto.Name = cyyptocollection["Name"];
                editcyrpto.Prefix = cyyptocollection["Prefix"];
                editcyrpto.MarketCap = double.Parse(cyyptocollection["MarketCap"]);
                editcyrpto.Price = double.Parse(cyyptocollection["Price"]);
                editcyrpto.CreatedBy = cyyptocollection["CreatedBy"];
                editcyrpto.CompanyId = cyyptocollection["CompanyId"];
                stockifyDB.SaveChanges(); 
                return RedirectToAction("Crypto");
            }
            catch
            {
                return View(Id);
            }
        }


        public ActionResult DeleteCrypto(string id)
        {
            var crypt = stockifyDB.Cryptos.Where(c => c.Id == id).FirstOrDefault();
            return View(crypt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCrypto(string Id, IFormCollection cyyptocollection)
        {
            

            try
            {

                Crypto crypt = stockifyDB.Cryptos.Where(c => c.Id == Id).FirstOrDefault();
                stockifyDB.Cryptos.Remove(crypt);
                stockifyDB.SaveChanges();
                return RedirectToAction("Crypto");

            }

            catch
            {
                return View(Id);
            }

        }


        public ActionResult CreatePortfolio()
        {
            return RedirectToAction("Portfolio1", "Portfolio1");
        }


    }
}
