using Microsoft.AspNetCore.Mvc;

namespace Stockify.Models
{
    public class Portfolio
    {
        private List<PortfolioStock> _stocks;

        public Portfolio()
        {
            _stocks = new List<PortfolioStock>();
        }

        public void AddStock(Stock stock)
        {
            var match = _stocks.FirstOrDefault(x => x.Id == stock.Id);
            if (match == null)
            {
                _stocks.Add(new PortfolioStock() { Id = stock.Id, Name = stock.Name, Price = stock.Price, Category = stock.Category, MarketCap = stock.MarketCap, EPS = stock.EPS, Quantity = 1 });
            }
            else
            {
                match.Quantity++;
            }
        }


        public double CalculateTotalPrice()
        {
            return _stocks.Sum(stock => stock.Price * stock.Quantity);
        }

        public double deleteportfolio()
        {
            _stocks.Clear();
            return _stocks.Count();
        }
    }
}
