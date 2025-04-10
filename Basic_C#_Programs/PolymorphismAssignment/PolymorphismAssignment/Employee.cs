using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Employee : Person, IQuittable //created an employee called that inherties from the Person class and the interface IQuittable
    {
        public override void SayName() //implimented the SayName() method inside the employee class
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
        public void Quit() //implimented the Quit method from the IQuittable interface
        {
            Console.WriteLine($"{firstName} {lastName} has decided to quit");
        }
    }
}
