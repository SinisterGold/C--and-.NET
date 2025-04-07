using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment
{
    public class MathMethods
    {
        //First method that takes an integer and returns an integer
        public int MathOp(int number)  //could of went public static int MathOp(...) to skip instantiating on Main()
        {
            return number * 5;
        }
        //Second method that takes a decimal and returns an interger
        public int MathOp(decimal number)
        {
            return (int)(number / 12.0m);
        }
        //Third MathOp method that takes a string and returns an integer
        public int MathOp(string number)
        {
            int newnumber = Convert.ToInt32(number);
            return newnumber + 4;
        }

    }
}
