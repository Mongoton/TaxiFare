using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiFare.Models
{
    public class TaxiFareModel
    {
        public string TaxiAbove6Min { get; set; }
        public string TaxiBelow6Min { get; set; }
        public DateTime RideDate { get; set; }
    }
}