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
            Discretionary,
            ConsumerStaples,
            Healthcare,
            Financials,
            Technology,
            Communication,
            Utilities,
            RealEstate
        }
        [Key]
        [Required(ErrorMessage = "Symbol Cannot be blank")]
        public string Symbol { get; set; }
        [Required(ErrorMessage = "Name Cannot be blank")]
        public string Name { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Market Cap(in Billions)")]
        public double MarketCap { get; set; }
        [Display(Name = "Date of IPO")]
        public DateOnly IPODate { get; set; }
        [Display(Name = "Price in €")]
        public double Price { get; set; }
        [Display(Name = "PE Ratio")]
        public double PERatio { get; set; }
        public string Industry { get; set; }
        public string Exchange { get; set; }
    }
}
