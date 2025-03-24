using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Raymir";
            //string quote = "The man said, \"Hello\", Raymir. \n Hello on a new line \n \t Hello on a tab";
            //string fileName = @"C:\Users\Raymir";

            //bool trueOrFalse = name.Contains("r");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(length);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Raymir");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
