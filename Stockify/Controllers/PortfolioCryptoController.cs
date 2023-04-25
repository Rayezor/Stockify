using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class PortfolioCryptoController : Controller
    {
        private StockifyContext stockifyDB;
        public PortfolioCryptoController()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }
        public ActionResult PortfolioCrypto()
        {
            return View(stockifyDB.Cryptos.OfType<PortfolioCrypto>().ToList());
        }
    }
}
