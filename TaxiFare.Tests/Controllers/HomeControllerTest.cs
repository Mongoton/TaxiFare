using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiFare;
using TaxiFare.Controllers;

namespace TaxiFare.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Taxi Fare", result.ViewBag.Title);
        }

        [TestMethod]
        public void GetRideInfo()
        {
            HomeController controller = new HomeController();

            TaxiFare.Models.TaxiFareModel samplefare1 = new TaxiFare.Models.TaxiFareModel();
            samplefare1.TaxiAbove6Min = "5";
            samplefare1.TaxiBelow6Min = "2";
            samplefare1.RideDate = new DateTime(2010, 10, 8, 5, 30, 0);

            JsonResult result = controller.GetRideInfo(samplefare1) as JsonResult;

            Assert.AreEqual("{ result = The total fare is: 9.25 }", result.Data.ToString());
        }

        [TestMethod]
        public void GetRideInfoNegative()
        {
            HomeController controller = new HomeController();
            
            TaxiFare.Models.TaxiFareModel samplefare1 = new TaxiFare.Models.TaxiFareModel();
            samplefare1.TaxiAbove6Min = "-5";
            samplefare1.TaxiBelow6Min = "-2";
            samplefare1.RideDate = new DateTime(2010, 10, 8, 5, 30, 0);

            JsonResult result = controller.GetRideInfo(samplefare1) as JsonResult;

            Assert.AreEqual("{ result = Please enter valid values. }", result.Data.ToString());
        }

        [TestMethod]
        public void GetRideInfoNightTime()
        {
            HomeController controller = new HomeController();

            TaxiFare.Models.TaxiFareModel samplefare1 = new TaxiFare.Models.TaxiFareModel();
            samplefare1.TaxiAbove6Min = "8";
            samplefare1.TaxiBelow6Min = "3";
            samplefare1.RideDate = new DateTime(2010, 10, 8, 10, 30, 0);

            JsonResult result = controller.GetRideInfo(samplefare1) as JsonResult;

            Assert.AreEqual("{ result = The total fare is: 12.05 }", result.Data.ToString());
        }
    }
}
