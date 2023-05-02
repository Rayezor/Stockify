using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Stockify.Data.Enums.Category;

namespace Stockify.Models
{
    public class Stock
    {
        [Key]
        [Required(ErrorMessage = "Symbol Cannot be blank")]
        [Display(Name = "Ticker Symbol")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Name Cannot be blank")]
        public string Name { get; set; }
        public Categories Category { get; set; }
        [Range(0, double.MaxValue),]
        [Display(Name = "Market Cap(in Billions)")]
        public double MarketCap { get; set; }
        [Range(0, double.MaxValue)]
        [Display(Name = "Price in €")]
        public double Price { get; set; }
        [Display(Name = "Stock Exchange")]
        public string Exchange { get; set; }
        [Display(Name = "Earnings Per Share (TTM)")]
        public double EPS { get; set; }
        [Display(Name = "PE Ratio (TTM)")]
        public double PERatio /*{ get; set; }*/
        {
            get
            {
                double peRatio = Price / EPS;
                return Math.Round(peRatio, 2);
            }
}
        //public Stock(string id, string name, double price, double marketCap, Categories category, string exchange, double ePS, double peRatio)
        //{
        //    this.Id = id;
        //    Name = name;
        //    Price = price;
        //    MarketCap = marketCap;
        //    Exchange = exchange;
        //    Category = category;
        //    EPS = ePS;
        //    PERatio = peRatio;
        //}

        //Relationships
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
