using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console.
            Console.WriteLine("Type your favorite whole number we will then multiply it by 50");
            string Num = Console.ReadLine();
            int favNum = Convert.ToInt32(Num);
            int productNum = favNum * 50;
            Console.WriteLine("Your number Multiplied by 50 is:" + productNum.ToString());

            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Type your favorite whole number we will then add 25 to it");
            string inputNum = Console.ReadLine();
            int intNum = Convert.ToInt32(inputNum);
            int sumNum = intNum + 25;
            Console.WriteLine("Your number added to 25 is:" + sumNum.ToString());

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Type your favorite whole number we will then divide it by 12.5");
            string typedNum = Console.ReadLine();
            double numerator = Convert.ToDouble(typedNum);
            double result = numerator / 12.5;
            Console.WriteLine("Your number divided by 12.5 is:" + result.ToString());


            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Input a number a whole number between 1 and 100 and we will see if it greater then my number");
            string guessed = Console.ReadLine();
            int guessedNum = Convert.ToInt32(guessed);
            bool tOrf = guessedNum > 50;
            Console.WriteLine("Is the number you guessed greater then my number:" + tOrf.ToString());



            //Takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Input a number and we will see if its divisable by 7. If it is the remainder will be 0");
            string argNum = Console.ReadLine();
            int intArgNum = Convert.ToInt32(argNum);
            int remainder = intArgNum % 7;
            Console.WriteLine("Your Number Divided by 7 has a remainder of:" + remainder.ToString());

        }
    }
}
