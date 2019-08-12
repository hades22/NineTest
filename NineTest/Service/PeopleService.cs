using NineTest.API;
using NineTest.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace NineTest.Service
{
    public class PeopleService
    {
        public static List<Person> InitPeople()
        {
            ObjectCache cache = MemoryCache.Default;
            if (cache["people"] == null)
            {
                List<Person> people = new List<Person>();
                Random rnd = new Random();
                for (int i = 0; i < 10000; i++)
                {
                    people.Add(CreatePerson(i, rnd));
                }
                cache["people"] = people;
            }
            return (List<Person>)cache["people"];
        }

        public static List<Person> AddAgeByOne(List<Person> personList)
        {
            personList.ForEach(p => p.Age = p.Age + 1);
            return personList;
        }

        public static List<Person> GetRace(string race, List<Person> personList)
        {
            if(race== "AnglesSaxons")
            {
                return personList.FindAll(p => p.Race == "AnglesSaxons" && p.Age % 2 == 0).OrderBy(p => p.Age).ToList();
            }

            if(race== "Jutes")
            {
                return personList.FindAll(p => p.Race == "Jutes" && p.Age % 2 == 0).OrderBy(p => p.Age).ToList();
            }

            if (race == "Hawaiian")
            {
                return personList.FindAll(p => p.Race == "Hawaiian" && p.Age % 2 == 0).OrderBy(p => p.Age).ToList();
            }

            return new List<Person>();
        }

        public static PeopleInfo GetInfo(List<Person> personList)
        {
            var info = new PeopleInfo()
            {
                Total = personList.Count(),
                AverageAge = personList.Average(p => p.Age),
                MaxAge = personList.Max(p => p.Age),
                MinAge = personList.Min(p => p.Age),
                AnglesSaxonsTotal = personList.Count(p => p.Race == "AnglesSaxons"),
                JutesTotal = personList.Count(p => p.Race == "Jutes"),
                HawaiianTotal = personList.Count(p => p.Race == "Hawaiian")

            };
            return info;
        }

        private static Person CreatePerson(int i, Random rnd)
        {
            int n = rnd.Next(0, 3);
            switch (n)
            {
                case 0:
                    return new AnglesSaxons()
                    {
                        Name = "Person #" + i.ToString(),
                        Age = rnd.Next(1, 99),
                        Race = "AnglesSaxons"
                    };
                case 1:
                    return new Jutes()
                    {
                        Name = "Person #" + i.ToString(),
                        Age = rnd.Next(1, 99),
                        Race = "Jutes"
                    };
                case 2:
                    return new Hawaiian()
                    {
                        Name = "Person #" + i.ToString(),
                        Age = rnd.Next(1, 99),
                        Race = "Hawaiian"
                    };
                default:
                    return new Person()
                    {
                        Name = "Person #" + i.ToString(),
                        Age = rnd.Next(1, 99),
                        Race = "NA"
                    };
            }
        }
    }
}