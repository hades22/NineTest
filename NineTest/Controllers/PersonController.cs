using NineTest.People;
using NineTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NineTest.Controllers
{
    public class PersonController : Controller
    {
        private List<Person> persons = PeopleService.InitPeople();
        // GET: Person
        public ActionResult Index(string race="")
        {
            var list = PeopleService.GetRace(race, persons);
            return View(list);
        }
    }
}