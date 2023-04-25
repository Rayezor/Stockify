using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stockify.Data;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class Portfolio1Controller : Controller
    {
        private static Portfolio1 portfolio = new Portfolio1();

        private StockifyContext stockifyDB;
        public Portfolio1Controller()
        {
            stockifyDB = new StockifyContext();
            stockifyDB.Database.EnsureCreated();
        }
        public ActionResult Portfolio1()
        {
            ViewBag.TotalPrice1 = portfolio.CalculateTotalPrice();
            return View(stockifyDB.Cryptos);
        }

        public ActionResult DeletePortfolio1()
        {
            portfolio.deleteportfolio1();
            return RedirectToAction("Portfolio1");
        }


        public ActionResult AddToPortfolio1(string id)
        {
            try
            {
                foreach (Crypto crypto in stockifyDB.Cryptos)
                {
                    if (crypto.Id == id)
                    {
                        portfolio.AddCrypto(crypto);
                        break;
                    }
                }

                return RedirectToAction("Portfolio1");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GoToCrypto()
        {
            return RedirectToAction("Crypto", "Crypto");
        }
        /*public ActionResult GoToPortfolio()
        {
            return RedirectToAction("PortfolioStock", "PortfolioStock");
        }*/
    }
}
