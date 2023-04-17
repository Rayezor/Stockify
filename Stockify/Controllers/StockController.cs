using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Models;
using static Stockify.Data.Enums.Category;
using static Stockify.Models.Stock;

namespace Stockify.Controllers
{
    public class StockController : Controller
    {
        private static List<Stock> stockList = new List<Stock>()
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
        };
        // GET: StockController
        public ActionResult Stock()
        {
            return View(stockList.OrderBy(s => s.Id).ToList());
        }

        // GET: StockController/Details/5
        public ActionResult Details(string id)
        {
            return View(id);
        }

        // GET: StockController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock newStock)
        {
            if (ModelState.IsValid)
            {
                stockList.Add(newStock);
                return RedirectToAction("Stock");
            }
            else
            {
                return View(newStock);
            }
        }

        // GET: StockController/Edit/5
        public ActionResult Edit()
        {
             return View();
        }

        // POST: StockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                Stock editFx = stockList.FirstOrDefault(p => p.Id.Equals(id));
                editFx.Price = int.Parse(collection["Price"]);
                editFx.MarketCap = int.Parse(collection["MarketCap"]);
                editFx.EPS = int.Parse(collection["EPS"]);

                return RedirectToAction("Stock");
            }
            catch
            {
                return View(id);
            }
        }

        // GET: StockController/Delete/5
        public ActionResult Delete(string id)
        {
            var stock = stockList.Where(c => c.Id == id).FirstOrDefault();
            return View(stock);
        }

        // POST: StockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var crypt = stockList.Where(c => c.Id == id).FirstOrDefault();
                stockList.Remove(crypt);
                return RedirectToAction("Stock");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
