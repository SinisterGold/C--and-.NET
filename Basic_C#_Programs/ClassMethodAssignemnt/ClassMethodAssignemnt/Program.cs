using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Calculator.DivideByTwo(userInput);

            int result;

            Calculator.DivideByTwo(userInput, out result);

            Console.WriteLine($"Using the overloaded method, {userInput} divided by 2 is: {result}");
        }
    }
}
