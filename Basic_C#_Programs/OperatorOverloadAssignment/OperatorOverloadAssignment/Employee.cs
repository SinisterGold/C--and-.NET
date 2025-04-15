using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    public class Employee
    {
        // Properties for Employee class
        public int Id { get; set; } // Unique identifier for the employee
        public string FirstName { get; set; } // First name of the employee
        public string LastName { get; set; } // Last name of the employee

        // Overload the == operator to compare two Employee objects
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are the same instance
            if (ReferenceEquals(emp1, emp2)) return true;

            // If one of the objects is null, return false
            if (emp1 is null || emp2 is null) return false;

            // Compare the Id properties for equality
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to ensure it works with == overload
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply use the opposite of the == operator
            return !(emp1 == emp2);
        }

        // Override the Equals method for correct behavior in collections
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and use the overloaded == operator
            if (obj is Employee employee)
            {
                return this == employee;
            }
            return false; // If not an Employee, return false
        }

        // Override the GetHashCode method to ensure consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Use Id's hash code for consistency
        }
    }
}

