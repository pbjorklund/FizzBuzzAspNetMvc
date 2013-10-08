using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        //
        // GET: /FizzBuzz/
        public ActionResult Index()
        {
            return View();
        }

        private string GenerateFizzBuzz(int value)
        {
            return String.Concat(Enumerable.Range(1, value).Select(i => (i % 5 == 0 && i % 3 == 0) ? "FizzBuzz " : i % 5 == 0 ? "Buzz " : i % 3 == 0 ? "Fizz " : String.Format("{0} ", i))).TrimEnd();
        }

        public ActionResult GetFizzBuzz(string value = "")
        {
            if (!string.IsNullOrEmpty(value))
                ViewBag.Output = GenerateFizzBuzz(Int32.Parse(value));
            return PartialView("_FizzBuzz");
        }
	}
}