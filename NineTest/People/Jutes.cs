using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NineTest.People
{
    public class Jutes:Person
    {
        public override double Height
        {
            get
            {
                return Age * 1.6 / 2;
            }
        }
    }
}