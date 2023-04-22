using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class PortfolioController : Controller
    {
        private static Portfolio portfolio = new Portfolio();

        private StockifyContext stockifyDB;
        public PortfolioController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }
        public ActionResult Portfolio()
        {
            ViewBag.TotalPrice = portfolio.CalculateTotalPrice();
            return View(stockifyDB.Stocks);
        }
        public ActionResult PortfolioContents()
        {
            return View();
        }
        public ActionResult AddToPortfolio(string id)
        {
            try
            {
                foreach (Stock stock in stockifyDB.Stocks)
                {
                    if (stock.Id == id)
                    {
                        portfolio.AddStock(stock);
                        break;
                    }
                }

                return RedirectToAction("Portfolio");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GoToStocks()
        {
            return RedirectToAction("Stock");
        }
    }
}
