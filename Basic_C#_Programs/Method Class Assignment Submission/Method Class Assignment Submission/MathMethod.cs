using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class MathMethod //defined a class called MathMethod
    {
        public void MathTime(int a, int b) //Defined a void method called MathTime that takes in two integer parameters
        {
            int square = a * a; //prefoprms a math operation on first integer aka squaring it

            
            Console.WriteLine("Your first number squared is: " + square); //displays the product of first integer squared


            Console.WriteLine("And the second number that you typed was: " + b); //displays what was typed for the ssecond integer

        }
    }
}
