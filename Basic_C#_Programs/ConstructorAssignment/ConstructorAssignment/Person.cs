using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        //chaining 2 constructors together
        public Person(string firstName, string lastName) : this(firstName, lastName, "Offline")
        {

        }
        public Person(string firstName, string lastName, string status)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = status;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
    }
}
