using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class CryptoController : Controller
    {

        private static List<Crypto> cryptolist = new List<Crypto>()
        {
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},
            new Crypto{Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Trump International"},

        };

        // GET: CryptoController
        public ActionResult Crypto()
        {
            return View();
        }

      
    }
}
