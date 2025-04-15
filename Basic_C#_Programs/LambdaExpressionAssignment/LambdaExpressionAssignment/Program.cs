using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee>  EmployeeList = new List<Employee>() //instanced an empoyee list and filled it with 10 employee with atleast 2 have the name Joe
            {
                new Employee { Id = 1, FirstName = "Ray", LastName = "Smith"},
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "David", LastName = "Lee" },
                new Employee { Id = 8, FirstName = "Anna", LastName = "Taylor" },
                new Employee { Id = 9, FirstName = "Chris", LastName = "Moore" },
                new Employee { Id = 10, FirstName = "Joe", LastName = "White" }
            };

            List<Employee> ListOfJoes = new List<Employee>(); //created a new list
            foreach (Employee employee in EmployeeList) //crated a foreach loop that will go threw the first list and find any empoyee with first name Joe
                                                        //and add it to ListOfJoes list
            {
                if (employee.FirstName == "Joe")
                {
                    ListOfJoes.Add(employee);
                }
            }
            List<Employee> ListOfJoes2 = EmployeeList.Where(x => x.FirstName == "Joe").ToList(); //using lambda function to doo the same as above

            List<Employee> ListOfIDs = EmployeeList.Where(x => x.Id > 5).ToList(); //using lmabda function to add everyone with an Id above 5 to a new list

            foreach(Employee Id in ListOfIDs) // this loop is not part of the assingment i just used it to check my work
            {
                Console.WriteLine(Id.FirstName);
            }
        }
    }
}
