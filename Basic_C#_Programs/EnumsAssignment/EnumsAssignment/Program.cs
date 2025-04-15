using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool actualday = false; //created a bool called actualday and gave it the value of false this is going to be used to make out try/catch repeat
            
            while(actualday == false) //a while loop that will contine to run as long as actualday is equal to false
            {
                try //the try block that will be run first
                {
                    Console.WriteLine("What is the current day of the week?"); //asking for user input
                    string userinput = Console.ReadLine(); //taking in user input
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userinput); //created an instance of DayOfTheWeek enum and called it day then we casted and paresed the user input into the enum DaysOfTheWeek
                    Console.WriteLine($"Have a happy {day}!"); //Printed out a mnessage that contained the day the user picked
                    actualday = true; //changed the valuse of actualday to true so the while loop would stop
                }
                catch (ArgumentException error) //grabbed any errors for in correct input and stored them in variable called error
                {
                    Console.WriteLine("Please input a valid day of the week."); //tells use to input a valid day of the week
                }
            }

        }

        public enum DaysOfTheWeek //created an enum called DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
