using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while
            int num = 0;
            do
            {
                Console.WriteLine("This is a do while loop"); 
                num++;
            }
            while (num < 10); //this will run 10 times starting from num = 0 to num = 9


            //This is a while loop
            int count = 0;
            while (count <20) //this will run 20 times starting from count = 0 to count = 19
            {
                Console.WriteLine("This is a while loop");
                count++;
            }
            Console.ReadLine();
        }
    }
}
