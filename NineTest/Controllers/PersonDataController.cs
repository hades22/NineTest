using NineTest.API;
using NineTest.People;
using NineTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NineTest.Controllers
{
    public class PersonDataController : ApiController
    {
        private List<Person> persons = PeopleService.InitPeople();

        [HttpGet]
        public PeopleInfo GetPeopleInfo()
        {
            return PeopleService.GetInfo(persons);
        }

    }
}
