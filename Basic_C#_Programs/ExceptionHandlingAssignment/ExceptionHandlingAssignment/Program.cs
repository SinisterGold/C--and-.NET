using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            try //anything between {} is run and if an error is found then catch{} is run
            {
                List<int> numberList = new List<int>() { 6, 50, 100 }; //creates a new list called numberList
                Console.WriteLine("Pick a number"); //asking for user intput to type a number
                int input = Convert.ToInt32(Console.ReadLine()); //converts user input from string to integer

                foreach (int number in numberList) //this iterates through the numberList I could of also used "for (int i = 0; i < numberList.Count; i++)"
            {
                    int result = number / input; //decales integer called result which is a product of lists index valuse at the time divided by user input
                    Console.WriteLine(number + " divided by " + input + " equals " + result); //prints the result to the user
                }
            }
            catch (Exception error) //a general can catch block that will grab an errors and assign them to the variable error
            {
                Console.WriteLine(error.Message); //this prints out the error message assigned to error
            }
            Console.WriteLine("We have emerged from the try/catch block!"); // a line outside the catch block to let users know they are no longer in the try/catch
            Console.ReadLine();
        }
    }


