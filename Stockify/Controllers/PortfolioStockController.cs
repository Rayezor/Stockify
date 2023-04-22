using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class PortfolioStockController : Controller
    {
        private StockifyContext stockifyDB;
        public PortfolioStockController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }
        public ActionResult PortfolioStock()
        {
            return View(stockifyDB.Stocks.OfType<PortfolioStock>().ToList());
        }
    }
}
