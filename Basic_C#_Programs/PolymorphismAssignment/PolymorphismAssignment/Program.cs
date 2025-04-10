using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" }; //instanted an employee object
            employee.SayName(); //called the SayName() method

            IQuittable anotheremployee = new Employee() { firstName = "Sam", lastName = "Fisher" }; //instanted an IQuittable object using polymorphism
            anotheremployee.Quit(); //called the Quit() method on that IQuittable object
        }
    }
}
