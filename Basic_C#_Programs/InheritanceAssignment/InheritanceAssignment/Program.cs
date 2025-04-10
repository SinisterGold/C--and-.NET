using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //instantiated the Employee class and created an object called employee and initialized it
            Employee employee = new Employee() {FirstName = "Sample", LastName = "Student" }; 
            
            //calling the superclass method SayName on the employee object
            employee.SayName();
        }
    }
}
