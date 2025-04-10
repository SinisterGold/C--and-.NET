using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Person //public class object called person with 2 properties
    {
        public string FirstName { get; set; } //prpertiy one is a string called FirstName
        public string LastName { get; set; } //property two is a string called LastName

        public void SayName() //created a public void method called SayName that will print "Name: FirstName LastName" to the console
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
