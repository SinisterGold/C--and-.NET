using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperation
    {
        //created a method that takes two integers as parameters 
        //made one of theme option by using a default value

        public int MathOp( int a, int b = 0)
        {
            //prefom addition
            int sum = a + b;

            return sum;
        }
    }
}
