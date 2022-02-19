using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam_KH.Models
{
    public class Product
    {
        [Display(Name = "Product Id")]
        [Required(ErrorMessage="please enter product id")]
        public int ProdctId { get; set; }

        [Display(Name ="Product Name")]
        [Required(ErrorMessage ="please Enter Product Name ")]
        public string ProductName { get; set; }

        [Display(Name = "Rate")]
        [Required(ErrorMessage = "please Enter Rate ")]
        public decimal Rate { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "please Enter Description ")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "please Enter Category ")]
        public string Category { get; set; }






    }
}