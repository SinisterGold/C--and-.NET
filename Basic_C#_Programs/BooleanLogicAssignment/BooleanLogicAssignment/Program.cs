using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ECHO, your friendly car insurance program!\n");
            
            //Age
            Console.WriteLine("What is your age?\n");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);

            //DUI Y or N
            Console.WriteLine("Have you ever had a DUI? Please respond with Y or N\n");
            string response = Console.ReadLine().ToLower(); //ToLower means that even if the input was Y or N it would be changed to y and n respectively
            bool dui = response == "y";

            //Number of tickets
            Console.WriteLine("How many speeding tickets do you have?\n");
            string ticket = Console.ReadLine();
            int ticketNum = Convert.ToInt32(ticket);

            //Do You qualify
            Console.WriteLine("Do you qualify?");
            bool results = (ageNum > 15) && dui == false && (ticketNum <= 3); //you can also use !dui since ! negates the valuse of the boolean variable dui meaning it dui = true then !dui = false making thw whole statement false
            Console.WriteLine(results);
        }
    }
}
