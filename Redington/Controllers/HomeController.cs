using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Redington.Models;

namespace Redington.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveResults( decimal probabilityOne, decimal probabilityTwo, string selectedOption, decimal result )
        {
            var calculation = new Calculation()
            {
                ProbabilityOne = probabilityOne,
                ProbabilityTwo = probabilityTwo,
                SelectedOption = selectedOption,
                Result = result
            };

            ////Saving to session (instead of using for example a databse)
            this.Session.Add( calculation.Guid.ToString(), calculation );

            Thread.Sleep( 1000 );

            return new JsonResult() { Data = string.Empty };
        }
    }
}