using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod Math = new MathMethod(); //insantiate the MathMethod class

            Math.MathTime(5, 20); //calling the MathTime method and passing two integers

            Math.MathTime(a: 5, b: 20); //calling maethod again but specifying parameters by name
        }
    }
}
