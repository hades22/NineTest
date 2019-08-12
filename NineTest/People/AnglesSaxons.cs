using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NineTest.People
{
    public class AnglesSaxons: Person
    {
        public override double Height
        {
            get
            {
                return 1.5 + Age * 0.45;
            }
        }
    }
}