﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stockify.Models;

namespace Stockify.Controllers
{
    public class CryptoController : Controller
    {

        private static List<Crypto> cryptolist = new List<Crypto>()
        {
            new Crypto{Id = "TSLA", Name="Bitcoin", Prefix="BTC", MarketCap=489.6, Price=29485, DateCreated=new DateOnly(2004, 1, 7), CreatedBy="Tesla Inc."},
            new Crypto{Id = "AMZN", Name="Elongate", Prefix="ELG", MarketCap=23, Price=0.32, DateCreated=new DateOnly(2017, 4, 8), CreatedBy="Amazon.com, Inc."},
            new Crypto{Id = "AAPL", Name="Doge", Prefix="DOG", MarketCap=180.2, Price=4.89, DateCreated=new DateOnly(2019, 8, 16), CreatedBy="Apple Inc"},
            new Crypto{Id = "MAERSK-B.CO", Name="Litecoin", Prefix="LTC", MarketCap=293.9, Price=10.3, DateCreated=new DateOnly(2001, 3, 27), CreatedBy="A.P. Møller - Mærsk A/Sc"}

        };

        // GET: CryptoController
        public ActionResult Crypto()
        {
            return View(cryptolist);
        }

        public ActionResult CreateCrypto(Crypto newcrypto)
        {
            if (ModelState.IsValid)
            {

                cryptolist.Add(newcrypto);
                return RedirectToAction("Crypto");

            }
            else
            {
                return View();
            }

        }

      
    }
}
