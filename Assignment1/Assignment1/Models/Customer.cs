using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Customer
    {
        public int customerId { get; set; } // primary key is mandatory so no need to put required

        [Required(ErrorMessage = "Please enter a valid Customer First Name")] 
        public string customerFirstName { get; set; }

        [Required(ErrorMessage = "Please enter a valid Customer Last Name")] 
        public string customerLastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid Customer Address")]
        public string customerAddress { get; set; }

        [Required(ErrorMessage = "Please enter a valid Customer City")] 
        public string customerCity { get; set; }

        [Required(ErrorMessage = "Please enter a valid Customer State")]
        public string customerState { get; set; }

        [Required(ErrorMessage = "Please enter a valid Customer Postal Code")] 
        public string customerPostalCode { get; set; }

        [Range(1, 100000, ErrorMessage = "Please select a country")]
        public int customerCountryId { get; set; }

        public Country customerCountry { get; set; } 

        public string customerEmail { get; set; } // The Email and Phone fields are optional.
        // All other fields are required.

        public string customerPhone { get; set; } 

    }
}
