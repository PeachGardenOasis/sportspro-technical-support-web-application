using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models
{
    public class Incident
    {
        public int incidentId { get; set; }
        [Required(ErrorMessage = "Please enter a valid Incident Title")]
        public string incidentTitle { get; set; }
        [Required(ErrorMessage = "Please enter a valid Incident Description")]
        public string incidentDescription { get; set; }
        [Required(ErrorMessage = "Please enter a valid Incident Customer")]
        public string incidentCustomer { get; set; } // in add/edit incidents page user must select customer and product from dropdown
        [Required(ErrorMessage = "Please enter a valid Incident Product")]
        public string incidentProduct { get; set; }
        public string incidentTechnician { get; set; }// The Technician and Data Opened fields are optional.
        // All other fields are required
        public DateTime incidentDateOpened { get; set; } 
        [Required(ErrorMessage = "Please enter a valid date for Incident Date Closed")]
        public DateTime incidentDateClosed { get; set; }

        public int? technicianId { get; set; }//To make the Technician field optional, make sure to specify a nullable int type (?int) for the TechnicianID
        //property of the Incident entity class.

    }
}
