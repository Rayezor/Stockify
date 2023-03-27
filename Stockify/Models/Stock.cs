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
        [Required]
        public string Symbol { get; set; }
        [Required]
        public string Name { get; set; }
        public Categories Category { get; set; }
        public DateTime IPODate { get; set; }
        public float Price { get; set; }
    }
}
