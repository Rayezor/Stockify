using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;
using System.Net;
using static Stockify.Data.Enums.Category;
using static Stockify.Models.Stock;

namespace Stockify.Controllers
{
    public class StockController : Controller
    {
        private StockifyContext stockifyDB;
        public StockController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }
        /*private static List<Stock> stockList = new List<Stock>()
        {
            new Stock
            {
                Id="TSLA", 
                Name="Tesla Inc.", 
                Category=Categories.ConsumerDiscretionary, 
                MarketCap=656.552, 
                Price=198.13, 
                EPS=3.44, 
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Id="AMZN",
                Name="Amazon.com, Inc.",
                Category=Categories.ConsumerDiscretionary,
                MarketCap=1059,
                Price=102.71,
                EPS = -0.28,
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Id="AAPL",
                Name="Apple Inc.",
                Category=Categories.Technology,
                MarketCap=2623,
                Price=165.91,
                EPS=5.93,
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Id="MAERSK-B.CO",
                Name="A.P. Møller - Mærsk A/S",
                Category=Categories.Industrials,
                MarketCap=212.814,
                Price=11470.00,
                EPS=10846.03,
                Exchange="OMX"
            },
        };*/
        // GET: StockController
        public ActionResult Stock()
        {
            return View(stockifyDB.Stocks.OrderBy(s => s.Id).ToList());
        }

        // GET: StockController/Details/5
        public ActionResult DetailsStock(string id)
        {
            Stock found = stockifyDB.Stocks.FirstOrDefault(p => p.Id.Equals(id));
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Stock");
            }
        }

        // GET: StockController/Create
        public ActionResult CreateStock()
        {
            return View();
        }

        // POST: StockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStock(Stock newStock)
        {
            if (ModelState.IsValid)
            {
                stockifyDB.Stocks.Add(newStock);
                stockifyDB.SaveChanges();
                return RedirectToAction("Stock");
            }
            else
            {
                return View(newStock);
            }
        }

        // GET: StockController/Edit/5
        public ActionResult EditStock(string id)
        {
            Stock stock = stockifyDB.Stocks.FirstOrDefault(p => p.Id.Equals(id));
            return View(stock);
        }

        // POST: StockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditStock(string id, IFormCollection stockCollection)
        {
            try
            {
                Stock stock = stockifyDB.Stocks.FirstOrDefault(p => p.Id.Equals(id));
                stock.Name = stockCollection["Name"];
                stock.Price = int.Parse(stockCollection["Price"]);
                stock.MarketCap = int.Parse(stockCollection["MarketCap"]);
                stock.EPS = int.Parse(stockCollection["EPS"]);
                stock.Quantity = int.Parse(stockCollection["Quantity"]);
                stockifyDB.SaveChanges();
                return RedirectToAction("Stock");
            }
            catch
            {
                return View(id);
            }
        }

        // GET: StockController/Delete/5
        public ActionResult DeleteStock(string id)
        {
            var stock = stockifyDB.Stocks.Where(c => c.Id == id).FirstOrDefault();
            return View(stock);
        }

        // POST: StockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteStock(string Id, IFormCollection stockCollection)
        {
            try
            {

                var stock = stockifyDB.Stocks.Where(c => c.Id == Id).FirstOrDefault();
                stockifyDB.Stocks.Remove(stock);
                return RedirectToAction("Stock");

            }

            catch
            {
                return View(Id);
            }
        }
    }
}
