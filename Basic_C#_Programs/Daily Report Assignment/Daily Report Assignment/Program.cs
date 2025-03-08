using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Careeer College \n\nStudent Daily Report");
            

            //Name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //Course
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            //Page Number
            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            int pageNum = Convert.ToInt32(yourPage);

            //Need Help T or F
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string TorF = Console.ReadLine();
            bool TrueOrFalse = Convert.ToBoolean(TorF);

            //Positive Experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourResponse = Console.ReadLine();

            //Other Feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string yourFeedback = Console.ReadLine();

            //How many Hours did you study
            Console.WriteLine("Hour name hours did you study today?");
            string studyHours = Console.ReadLine();
            int hours = Convert.ToInt32(studyHours);

            //Closing Statement
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly.Have a great day!");
            Console.ReadLine();




        }
    }
}
