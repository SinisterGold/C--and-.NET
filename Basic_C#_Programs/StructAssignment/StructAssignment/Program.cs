using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(); //created an imstance of Number called num
            num.Amount = 12.95m; //Assign the Amount properity in num the valuse of 12.95
            Console.WriteLine(num.Amount); //printed the properity Amount of num to the console
        }
    }
}
