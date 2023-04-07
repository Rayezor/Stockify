using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stockify.Models
{
    public class Stock
    {
        public enum Categories
        {
            Energy,
            Materials,
            Industrials,
            [Display(Name = "Consumer Discretionary")]
            ConsumerDiscretionary,
            [Display(Name = "Consumer Staples")]
            ConsumerStaples,
            Healthcare,
            Financials,
            Technology,
            Communication,
            Utilities,
            [Display(Name = "Real Estate")]
            RealEstate
        }
        [Key]
        [Required(ErrorMessage = "Symbol Cannot be blank")]
        [Display(Name = "Ticket Symbol)")]
        public string Symbol { get; set; }
        [Required(ErrorMessage = "Name Cannot be blank")]
        public string Name { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Market Cap(in Billions)")]
        public double MarketCap { get; set; }
        [Display(Name = "Price in €")]
        public double Price { get; set; }
        public string Industry { get; set; }
        [Display(Name = "Stock Exchange")]
        public string Exchange { get; set; }
        [Display(Name = "Earnings Per Share (TTM)")]
        public double EPS { get; set; }
        [Display(Name = "PE Ratio (TTM)")]
        public double PERatio
        {
            get
            {
                double peRatio = Price/EPS;
                return Math.Round(peRatio, 2);
            }
        }
        public double Quantity { get; set; }
        [Display(Name = "All stock value")]
        public double TotalStockValue
        {
            get
            {
                double totalStockValue = Price*Quantity;
                return Math.Round(totalStockValue, 2);
            }
        }
    }
}
