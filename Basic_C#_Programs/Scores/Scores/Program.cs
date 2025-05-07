using System;
using System.Collections.Generic;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your name.");
            String date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\rmutu\OneDrive\Desktop\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            
            double tScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");

            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;

            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();



            //EXTRA REVIEW
            string[] stringArray = { "A", "B", "C" };
            Console.WriteLine("Pick a number from 0-2");
            bool valid = false;
            int uNumber = Convert.ToInt32(Console.ReadLine());
           
            

            while (!valid)
            {
                try
                {
                    Console.WriteLine($"The string a index {uNumber} is {stringArray[uNumber]}");
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid number pick a number between 0 and 2");
                    uNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(stringArray[i]);
                }
                 
            }

            List<int> NUM = new List<int> { 4, 67, 30, 98, 50 };
            List<int> NUM2 = new List<int>();

            for (int i = 0; i < NUM.Count; i++)
            {
                if (NUM[i] > 30)
                {
                    NUM2.Add(NUM[i]);
                }
            }

            foreach (int num2 in NUM2)
            {
                Console.WriteLine(num2);
            }

            Console.WriteLine(NUM2.Count);

            List<string> things = new List<string> { "A", "B", "C", "D", "E" };
            Console.WriteLine("write something");
            string userInput = Console.ReadLine();

        }
    }
}
