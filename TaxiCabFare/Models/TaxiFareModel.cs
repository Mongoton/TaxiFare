using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiCabFare.Models
{
    public class TaxiFareModel
    {
        public string TaxiAbove6Min { get; set; }
        public string TaxiBelow6Min { get; set; }
        public string RideDate { get; set; }
        public string RideTime { get; set; }
    }
}