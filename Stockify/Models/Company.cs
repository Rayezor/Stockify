using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stockify.Models
{
    public class Company
    {

        [Key]
        [Required(ErrorMessage = "ID Cannot be blank")]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Company Cannot be blank")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Formation Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Number of Employees")]
        public int Employees { get; set; }

        [Display(Name = "Stock Market")]
        public string Market { get; set; }

        public string Industry { get; set; }

        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Headquarters Location")]
        public string Headquarters { get; set; }

        // Foreign keys
        [Display(Name = "Ticker Symbol")]
        public string StockId { get; set; }

        [ForeignKey("StockId")]
        public Stock Stock { get; set; }

        [Display(Name = "Crypto Id")]
        public string CryptoId { get; set; }

        [ForeignKey("CryptoId")]
        public Crypto Crypto { get; set; }















    }
}
