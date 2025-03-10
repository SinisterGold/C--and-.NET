using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Title
            Console.WriteLine("Anonymous Income Comparison Program\n");

            //Person 1

            //P1 Rate
            Console.WriteLine("Person 1\n");
            Console.WriteLine("What is your hourly rate?");
            string p1Rate = Console.ReadLine();
            int intp1Rate = Convert.ToInt32(p1Rate);

            //P1 Hours
            Console.WriteLine("\nHow many hours do you work a week?");
            string p1Hours = Console.ReadLine();
            int intp1Hours = Convert.ToInt32(p1Hours);


            //Person 2

            //P2 Rate
            Console.WriteLine("\nPerson 2\n");
            Console.WriteLine("What is your hourly rate?");
            string p2Rate = Console.ReadLine();
            int intp2Rate = Convert.ToInt32(p2Rate);

            //P2 Hours
            Console.WriteLine("\nHow many hours do you work a week?");
            string p2Hours = Console.ReadLine();
            int intp2Hours = Convert.ToInt32(p2Hours);



            //Annual Salary of Person 1
            int p1annualSalary = intp1Rate * intp1Hours * 52; //52 weeks in a year
            Console.WriteLine("\nPerson 1 Annual Salary is: " +"$" + p1annualSalary.ToString());

            //Annual Salary of Person 2
            int p2annualSalary = intp2Rate * intp2Hours * 52; //52 weeks in a year
            Console.WriteLine("\nPerson 1 Annual Salary is: " + "$" + p2annualSalary.ToString());


            //Person 1 and 2 Comparison
            Console.WriteLine("\nPerson 1 makes more money than Person 2?");
            bool trueOrfalse = p1annualSalary > p2annualSalary;
            Console.WriteLine(trueOrfalse);
            Console.ReadLine();
        }
    }
}
