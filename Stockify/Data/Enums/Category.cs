using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Stockify.Data.Enums
{
    public class Category
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
    }
}
