using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Accelerantx.MVCWebApp.Models;

namespace Accelerantx.MVCWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation model)
        {
            model.Result = 1111;
            return View(model);
        }
    }
}