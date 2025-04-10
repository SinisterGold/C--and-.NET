using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public abstract class Person //created an abstract class called person with 2 string properties firstName, lastName
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName(); //created abstract method called SayName
    }
}
