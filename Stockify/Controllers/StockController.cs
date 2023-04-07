using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;
using static Stockify.Models.Stock;

namespace Stockify.Controllers
{
    public class StockController : Controller
    {
        private static List<Stock> stockList = new List<Stock>()
        {
            new Stock
            {
                Symbol="TSLA", 
                Name="Tesla Inc.", 
                Category=Categories.ConsumerDiscretionary, 
                MarketCap=656.552, 
                Price=198.13, 
                EPS=3.44, 
                Industry = "Auto Manufacturing", 
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Symbol="AMZN",
                Name="Amazon.com, Inc.",
                Category=Categories.ConsumerDiscretionary,
                MarketCap=1059,
                Price=102.71,
                EPS = -0.28,
                Industry = "Catalog/Specialty Distribution",
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Symbol="AAPL",
                Name="Apple Inc.",
                Category=Categories.Technology,
                MarketCap=2623,
                Price=165.91,
                EPS=5.93,
                Industry = "Computer Manufacturing",
                Exchange="NASDAQ-GS"
            },
            new Stock
            {
                Symbol="MAERSK-B.CO",
                Name="A.P. Møller - Mærsk A/S",
                Category=Categories.Industrials,
                MarketCap=212.814,
                Price=11470.00,
                EPS=10846.03,
                Industry = "Freight transport",
                Exchange="OMX"
            },
        };
        // GET: StockController
        public ActionResult Stock()
        {
            return View(stockList.OrderBy(s => s.Symbol).ToList());
        }

        // GET: StockController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StockController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Stock newStock = new Stock() {
                    Symbol = collection["Symbol"],
                    Name = collection["Name"],
                    // Category = Categories.Parse(),
                    MarketCap = int.Parse(collection["MarketCap"]),
                    Price = int.Parse(collection["Price"]),
                    Industry = collection["Industry"],
                    Exchange = collection["Exchange"],
                    EPS = int.Parse(collection["EPS"]),

                };
                stockList.Add(newStock);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StockController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: StockController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StockController/Delete/5
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
