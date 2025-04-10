using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignemnt
{
    public static class Calculator //Declare a static class so it does not need to be insantiated
    {
        public static void DivideByTwo(int num) // A method that divides an integer by 2 and outputs a result
        {
            int result = num / 2; //calculating the result

            Console.WriteLine(num + " divided by 2 is " + result); //printing it to the screen
        }

        public static void DivideByTwo(int num, out int output) //overloaded method that takes an integer and an output parameter to return as result
        {
            output = num / 2; //calculate by dividing by 2
        }
    }
}
