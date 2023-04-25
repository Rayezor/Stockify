using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stockify.Models
{
    public class PortfolioCrypto : Crypto
    {
        public double Quantity { get; set; }

    }
}
