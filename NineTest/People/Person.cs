using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NineTest.People
{
    public class Person: IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
        public virtual double Height
        {
            get
            {
                return 0;
            }
        }
    }
}