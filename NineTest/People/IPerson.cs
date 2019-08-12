using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineTest.People
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        double Height { get; }
    }
}
