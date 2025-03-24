using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Array
            string[] showArray = { "Reacher", "Invinciable", "Vox Machina", "The Black List", "The Boys" };

            Console.WriteLine("Select a number between 0 and 5:"); //asks the user to slect a number between 0 and 5
            
            int selectedNum = Convert.ToInt32(Console.ReadLine());//Takes input which is a string and then converts it to in integer

            if (selectedNum <= 5 && selectedNum >= 0) //checks to see if number is between 0 and 5 if so then code between "{ }" runs
            {
                Console.WriteLine("The current show I am watching is: " + showArray[selectedNum]);
            }
            else //if number inputed is not between 0 and 5 then this code runs
            {
                Console.WriteLine("The number you slected is not between 0 and 5.");
            }

            //Integer Array
            int[] favNum = { 1337, 100001, 99, 44, 101 }; 

            Console.WriteLine("Select another number between 0 and 5:"); //asks the user to slect a number between 0 and 5
            
            int pickedNum = Convert.ToInt32(Console.ReadLine()); //Takes input which is a string and then converts it to in integer

            if (pickedNum <= 5 && pickedNum >= 0) //checks to see if number is between 0 and 5 if so then code between "{ }" runs
            {
                Console.WriteLine("My favorite number is: " + favNum[pickedNum]);
            }
            else //if number inputed is not between 0 and 5 then this code runs
            {
                Console.WriteLine("The number you slected is not between 0 and 5.");
            }

            //List of strings
            List<string> favGame = new List<string>() { "The First Descendant", "Elden Ring", "Borderlands 2", "Helldivers 2", "Monster Hunter" }; //A List of games 
            
            Console.WriteLine("Select one more time a number between 0 and 5:"); //asks the user to slect a number between 0 and 5
            
            int finalNum = Convert.ToInt32(Console.ReadLine()); //Takes input which is a string and then converts it to in integer
            
            if (finalNum <= 5 && finalNum >= 0) //checks to see if number is between 0 and 5 if so then code between "{ }" runs
            {
                Console.WriteLine("My favorite video game is: " + favGame[finalNum]);
            }
            else //if number inputed is not between 0 and 5 then this code runs
            {
                Console.WriteLine("The number you slected is not between 0 and 5.");
            }
        }
    }
}
