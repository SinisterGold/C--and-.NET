﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();
            //Ctrl+K+C to comment a line and Ctrl+K+U to uncomment a line

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudy = true;

            byte hoursWorked = 42;

            sbyte currentTemperature = -23;

            char questionMark = '\u2103';
            Console.WriteLine(questionMark);
            Console.ReadLine();

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Ray";

            int currentAge = 247;
            string yearsOld = currentAge.ToString();

            bool isSnowing = true;
            string snowingStatus = Convert.ToString(isSnowing);
            Console.WriteLine(snowingStatus);
            Console.ReadLine();

        }
    }
}
