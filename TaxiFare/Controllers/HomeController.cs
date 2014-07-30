using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiFare.Models;


namespace TaxiFare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Taxi Fare";
            return View();
        }

        [HttpPost]
        public JsonResult GetRideInfo(TaxiFareModel rideinfo)
        {
            string result = "";
            double total = 0;
            try
            {
                int above6min = Int32.Parse(rideinfo.TaxiAbove6Min); // per minute over 6 mph 
                double below6min = double.Parse(rideinfo.TaxiBelow6Min); // per 1/5 mile below 6mph
                total += 3.5 + (0.35 * above6min) + (0.35 * below6min * 5);

                DateTime taxidate = rideinfo.RideDate.Date;

                DateTime FourPM = Convert.ToDateTime("4:00 PM");
                DateTime EightPM = Convert.ToDateTime("8:00 PM");
                DateTime SixAM = Convert.ToDateTime("6:00 AM");

                int duringrushhour1 = DateTime.Compare(taxidate, FourPM);
                int duringrushhour2 = DateTime.Compare(taxidate, EightPM);
                int nighttime1 = DateTime.Compare(taxidate, EightPM);
                int nighttime2 = DateTime.Compare(taxidate, SixAM);

                if (duringrushhour1 >= 0 && duringrushhour2 <= 0 && taxidate.DayOfWeek != DayOfWeek.Sunday && taxidate.DayOfWeek != DayOfWeek.Saturday)
                {
                    total++;
                }
                if (nighttime1 >= 0 || nighttime2 <= 0)
                {
                    total += 0.5;
                }

                if (total < 0)
                {
                    return Json(new{result = "Please enter valid values."});
                }

                result = "The total fare is: " + total.ToString();
            }
            catch (Exception e)
            {
                result = "Please enter valid values";
            }
            return Json(new { result });
        }
    }
}
