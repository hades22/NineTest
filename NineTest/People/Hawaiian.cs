using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NineTest.People
{
    public class Hawaiian:Person
    {
        public override double Height
        {
            get
            {
                return 1.7 + (Age + 2) * 0.23;
            }
        }
    }
}