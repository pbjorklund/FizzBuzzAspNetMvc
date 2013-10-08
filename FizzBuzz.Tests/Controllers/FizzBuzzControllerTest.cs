using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using FizzBuzz.Controllers;

namespace FizzBuzz.Tests.Controllers
{
    [TestClass]
    public class FizzBuzzControllerTest
    {
        [TestMethod]
        public void GivenNullReturnNothing()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz() as PartialViewResult;
            string expected = null;
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given1Return1()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz("1") as PartialViewResult;
            string expected = "1";
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given3Return12Fizz()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz("3") as PartialViewResult;
            string expected = "1 2 Fizz";
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given5Return12Fizz4Buzz()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz("5") as PartialViewResult;
            string expected = "1 2 Fizz 4 Buzz";
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given15Return12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz("15") as PartialViewResult;
            string expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given36Return12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19BuzzFizz2223FizzBuzz26Fizz2829FizzBuzz3132Fizz34BuzzFizz()
        {
            FizzBuzzController controller = new FizzBuzzController();
            PartialViewResult result = controller.GetFizzBuzz("36") as PartialViewResult;
            string expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz";
            string actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);
        }
        
    }
}
