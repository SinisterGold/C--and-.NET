using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person //created abstract class called person with 2 string properties fristName, lastName
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName(); //created abstract method called SayName
    }
    
}
