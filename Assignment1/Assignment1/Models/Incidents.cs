using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Incidents
    {
        public int incidentsId { get; set; }

        public string incidentsTitle { get; set; }

        public string incidentsCustomer { get; set; }

        public double incidentsProduct { get; set; }

        public DateTime dateOpened { get; set; }
    }
}
