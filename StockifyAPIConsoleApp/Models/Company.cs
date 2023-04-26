﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


   
namespace StockifyAPIConsoleApp.Models
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

            // Foreign key   
            //[Display(Name = "Stock Id")]
            //public virtual string StockId { get; set; }

            //[ForeignKey("Id")]
            //public virtual Stock Stock { get; set; }















        }
    

}
