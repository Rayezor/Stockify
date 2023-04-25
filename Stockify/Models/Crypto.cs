using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Security;

namespace Stockify.Models
{
    public class Crypto
    {
        [Key]
        [Required(ErrorMessage = "ID Cannot be blank")]
        [Display(Name = "ID")]
        public string Id { get; set; }


        [Required(ErrorMessage = "Name Cannot be blank")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prefix Cannot be blank")]
        [StringLength(3)]
        public string Prefix { get; set; }

        [Display(Name = "Market Cap(in Billions)")]
        [Range(0, double.MaxValue)]
        public double MarketCap { get; set; }

        [Required(ErrorMessage = "Price Cannot be blank")]
        [Display(Name = "Price in €")]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Date Cannot be blank")]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        // Foreign key 
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [ForeignKey("CompanyName")]
        public virtual Company Company { get; set; }


    }
}
