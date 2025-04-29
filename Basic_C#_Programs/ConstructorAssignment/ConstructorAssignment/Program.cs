using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Sam Fisher"; //created a constant variable

            var funList = new List<string>(); //created a variable using var keyword

            Person employee = new Person("Luke", "Cage", "Away");

            Console.ReadLine();
        }
    }
}
