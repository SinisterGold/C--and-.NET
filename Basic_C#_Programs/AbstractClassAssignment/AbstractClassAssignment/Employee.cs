using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
     public class Employee : Person //created another class called employee that inherited from person call
    {
        public override void SayName() //implimented the SayName() method inside the employee class
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
