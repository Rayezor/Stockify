using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class CryptoController : Controller
    {

        private static List<Crypto> cryptolist = new List<Crypto>()
        {
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Black Hand"},
            new Crypto{Name="Elongate", Prefix="ELG", MarketCap=23, Price=0.32, DateCreated=new DateOnly(2017, 4, 8), CreatedBy="Horizon Zero Dawn"},
            new Crypto{Name="Doge", Prefix="DOG", MarketCap=180.2, Price=4.89, DateCreated=new DateOnly(2019, 8, 16), CreatedBy="The Wild Hunt"},
            new Crypto{Name="Litecoin", Prefix="LTC", MarketCap=293.9, Price=10.3, DateCreated=new DateOnly(2001, 3, 27), CreatedBy="The ICA"},
            new Crypto{Name="Binance Currency", Prefix="BNB", MarketCap=400.2, Price=489.2, DateCreated=new DateOnly(2014, 9, 2), CreatedBy="The Hidden Ones"},
            new Crypto{Name="Matic", Prefix="MAT", MarketCap=3.5, Price=0.04, DateCreated=new DateOnly(2021, 1, 2), CreatedBy="The Institute"},
            new Crypto{Name="Atomic", Prefix="ATO", MarketCap=0.02, Price=0.003, DateCreated=new DateOnly(2023, 2, 1), CreatedBy="Stonecutters"},

        };

        // GET: CryptoController
        public ActionResult Crypto()
        {
            return View(cryptolist);
        }

      
    }
}
