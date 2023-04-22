using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stockify.Models
{
    public class PortfolioStock : Stock
    {
        public double Quantity { get; set; }
        /*public PortfolioStock(Stock stock, int qty) : base(stock.Id, stock.Name, stock.Price, stock.MarketCap, stock.Category, stock.Exchange, stock.EPS, stock.PERatio)
        {
            Quantity = qty;
        }*/
    }
}
