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
            new Stock{
                Symbol="TSLA", 
                Name="Tesla Inc.", 
                Category=Categories.Discretionary, 
                MarketCap=656.552, 
                IPODate=new DateOnly(2010, 6, 29), 
                Price=198.13, 
                PERatio=57.45, 
                Industry = "Auto Manufacturing", 
                Exchange="NASDAQ-GS"},
            new Stock{
                Symbol="AMZN",
                Name="Amazon.com, Inc.",
                Category=Categories.Discretionary,
                MarketCap=1059,
                IPODate=new DateOnly(1997, 5, 15),
                Price=102.71,
                PERatio=77,
                Industry = "Catalog/Specialty Distribution",
                Exchange="NASDAQ-GS"},
            new Stock{
                Symbol="AAPL",
                Name="Apple Inc.",
                Category=Categories.Technology,
                MarketCap=2623,
                IPODate=new DateOnly(1980, 12, 12),
                Price=165.91,
                PERatio=28.20,
                Industry = "Computer Manufacturing",
                Exchange="NASDAQ-GS"},
        };
        // GET: StockController
        public ActionResult Stock()
        {
            return View(stockList);
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
                return RedirectToAction(nameof(Index));
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
