using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Incident
    {
        public int incidentId { get; set; }

        public string incidentTitle { get; set; }

        public string incidentCustomer { get; set; }

        public string incidentProduct { get; set; }

        public DateTime dateOpened { get; set; }
    }
}
