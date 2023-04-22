using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static Stockify.Data.Enums.Category;

namespace Stockify.Models
{
    public class Stock
    {
        [Key]
        [Required(ErrorMessage = "Symbol Cannot be blank")]
        [Display(Name = "Ticket Symbol")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Name Cannot be blank")]
        public string Name { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Market Cap(in Billions)")]
        public double MarketCap { get; set; }
        [Display(Name = "Price in €")]
        public double Price { get; set; }
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
        /*public Stock(String _id, String _name, Categories _category, double _marketcap, double _price, String _exchange, double _eps, double _peRatio)
        {
            Id = _id;
            Name = _name;
            Category = _category;
            MarketCap = _marketcap;
            Price = _price;
            Exchange = _exchange;
            EPS = _eps;
        }*/
    }
}
