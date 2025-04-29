using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($" The current time is: {currentTime}");

            Console.WriteLine("Pick a number to see what time ti will be in that many hours.");
            double userInput = double.Parse(Console.ReadLine());

            Console.WriteLine("In {0} hours the time will be {1}", userInput, DateTime.Now.AddHours(userInput));

        }
    }
}
