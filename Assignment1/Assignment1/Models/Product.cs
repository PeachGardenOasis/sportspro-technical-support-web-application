using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Product
    {
        public int productId { get; set; }

        public string productCode { get; set; }

        public string productName { get; set; }

        public double productPrice { get; set; }

        public DateTime releaseDate { get; set; }
    }
}
