using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models
{
    public class Product
    {
        public int productId { get; set; }
        [Required(ErrorMessage = "Please enter a valid Product Code")]
        public string productCode { get; set; }
        [Required(ErrorMessage = "Please enter a valid Product Name")]
        public string productName { get; set; }
        [Required(ErrorMessage = "Please enter a valid Product Price")]
        public double productPrice { get; set; }

        public DateTime releaseDate { get; set; }
    }
}
