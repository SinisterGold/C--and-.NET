using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the wecome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            //weight message
            Console.WriteLine("Please enter package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());//This take the package weight that is a string and converst it to an int

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //width message
                Console.WriteLine("What is the package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine()); //This take the package width that is a string and converst it to an int

                //height mesage
                Console.WriteLine("What is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine()); //This take the package height that is a string and converst it to an int

                //length message
                Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine()); //This take the package length that is a string and converst it to an int

                if (packageWidth + packageHeight + packageLength > 50) //Check to see if the sum of the 3 dimensions is greater then 50 if ti is the program ens and gives an error message
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int quote = (packageHeight * packageLength * packageWidth * packageWeight) / 100; //multiple dimsions by weight then devides by 100 to give the quote for shipping

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString() +"\nThank You!");
                }
            }
        }
    }
}
