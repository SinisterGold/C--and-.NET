using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the MathOperation Class
            MathOperation Sum = new MathOperation();

            //asking for first number
            Console.WriteLine("Enter an Integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //asking for second number
            Console.WriteLine("Enter a second number or just press enter: ");

            //we are going to use a try/catch block here 
            //we will first try assuming they entered 2 numbers however if they did not we will run the same function just using the one number
            try
            {
                //calling method assuming 2 numbers were input
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = Sum.MathOp(num1, num2);
                Console.WriteLine("The sum of the numbers you enter is: " + result);
            }
            catch
            {
                //calling the method using only 1 number and the defulat value
                int result = Sum.MathOp(num1);
                Console.WriteLine("The sum of the number input is: " + result);
            }
            Console.ReadLine();

        }
    }
}
