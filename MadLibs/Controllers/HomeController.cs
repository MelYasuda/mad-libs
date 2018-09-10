using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        public string Hello() { return "Hello friend!"; }

        [Route("/")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/madlib")]
        public ActionResult MadLibTemplate()
        {
          MadLibVariable myMadLibVariable = new MadLibVariable();
          myMadLibVariable.SetName(Request.Query["person1"]);
          myMadLibVariable.SetAnotherName(Request.Query["person2"]);
          myMadLibVariable.SetAnimal(Request.Query["animal"]);
          myMadLibVariable.SetExclamation(Request.Query["exclamation"]);
          myMadLibVariable.SetNoun(Request.Query["noun"]);
          return View("MadLibTemplate", myMadLibVariable);
        }
    }
}
