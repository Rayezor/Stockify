using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


        //private static List<Crypto> cryptolist = new List<Crypto>()
        //{
        //    new Crypto{Id = "TSLA", Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateTime(2004, 1, 7), CreatedBy="Tesla Inc."},
        //    new Crypto{Id = "AMZN", Name="Elongate", Prefix="ELG", MarketCap=23, Price=0.32, DateCreated=new DateTime(2017, 4, 8), CreatedBy="Amazon.com, Inc."},
        //    new Crypto{Id = "AAPL", Name="Doge", Prefix="DOG", MarketCap=180.2, Price=4.89, DateCreated=new DateTime(2019, 8, 16), CreatedBy="Apple Inc"},
        //    new Crypto{Id = "MAERSK-B.CO", Name="Litecoin", Prefix="LTC", MarketCap=293.9, Price=10.3, DateCreated=new DateTime(2001, 3, 27), CreatedBy="A.P. Møller - Mærsk A/Sc"}

        //};



        // GET: CryptoController
        public ActionResult Crypto()
        {
            return View(stockifyDB.Cryptos.OrderBy(s => s.Id).ToList());
        }

        // GET: CryptoController/Details
        public ActionResult Details(string id)
        {
            Crypto found = stockifyDB.Cryptos.FirstOrDefault(p => p.Id.Equals(id));
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Crypto");
            }
        }

        // GET: CryptoController/Create
        public ActionResult CreateCrypto(Crypto newcrypto)
        {
            if (ModelState.IsValid)
            {

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
                editcyrpto.MarketCap = int.Parse(cyyptocollection["MarketCap"]);
                editcyrpto.Price = int.Parse(cyyptocollection["Price"]);
                editcyrpto.CreatedBy = cyyptocollection["CreatedBy"];
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




    }
}
