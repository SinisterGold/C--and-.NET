using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number:");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:\Users\rmutu\OneDrive\Desktop\Basic_C#_Programs\Logs\log.txt", userInput);

            string text = File.ReadAllText(@"C:\Users\rmutu\OneDrive\Desktop\Basic_C#_Programs\Logs\log.txt");

            Console.WriteLine($"This is what the log contained: {text}");

        }
    }
}
