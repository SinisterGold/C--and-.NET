using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {

        //ASSIGNMENT PART 1

        //One dimension string array
        string[] names = { "Ray", "Travis", "Zack", "Mark", "Steven" };

        //Asking user for input
        Console.WriteLine("What is your name?");
        string input = Console.ReadLine();

        //Loop to append user input to each string in the array
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + input;
        }

        //Second loop that writes out every updated element in the array
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        
        //ASSIGNMENT PART 2

        //Infinite Loop
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine(x);
        }
        //The loop abovbe would go on forever if you changed "x < 10" to "x >= 0"

        //ASSIGNMENT PART 3

        //Loop using < operator
        for (int j = 0; j < 20; j++)
        {
            Console.WriteLine("We Are Counting: " + j);
        }

        //Loop using <= operator
        for (int j = 0; j <= 20; j++)
        {
            Console.WriteLine("We Are Counting: " + j);
        }

        //ASSIGNMENT PART 4

        //a list containing names of friends
        List<string> friends = new List<string>() { "Luke", "Travis", "Mark", "Steven", "Matthew" };

        //primpt for the user to input a guess and then save that guess as a string
        Console.WriteLine("Try to guess the name of one of my friends:");
        string guess = Console.ReadLine();

        //this goes threw the above list and checks to see if any entry matches the user input if so the code in the {} brackets runts
        if (friends.Contains(guess))
        {
            //writes in the console that the user guess was coreect and lists where in the list the match was found
            Console.WriteLine("You are corret " + guess +" is on the list and there index is: " + friends.IndexOf(guess));
        }
        //if no match was found using thet input this is run
        else
        {
            Console.WriteLine("The name you submitted is not on the list");
        }


        //ASSIGNMENT PART 5

        //a list containing fruit
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "banana", "kiwi", "orange" };

        //a prompt for user input
        Console.WriteLine("Try to guess a fruit that is contained in the list");

        //takes users input saves it as a string then converts it to lowercase
        string userInput = Console.ReadLine().ToLower();

        //creates an empty list that will contain intergers
        List<int> matchingIndices = new List<int>();

        //this for loop starts at 0 and interates threw the above fruit list until it reaches the end
        for (int i = 0; i < fruits.Count; i++)
        {
            //fruits[i] gives back a string so fruits[0] = apple. So sine the above for loop[ is goign threw every index in the list
            //this if state make takes each element in the list and conpare it to the user input to see if there is a match
            //if there is a match the code in {} runs
            if (fruits[i].ToLower() == userInput)
            {
                //this takes the index value of the matching item in the list and adds it to the empty integer list we created above
                //for example if we guessed banana then it would add 1 and 3 to the inter list would now look like {1,3}
                matchingIndices.Add(i);
            }
        }
        
        //This line says if the interger list contains atleast 1 item aka the user guessed something that was in the fruit list then run the code in {}
        if (matchingIndices.Count > 0)
        {
            //this write to the console and till the user they are correct it then repeats that the using input with "userInput"
            //the matching idces are then listed
            //the way they are lists is as follows string.Join(",", matchingIndices));
            //the list matchingIndices contains intergers so to conver them to a string so we can concatinate them we use string.Join()
            //.Join need 2 inputs the first input is how you want the element seperate in this cause we choose ", "
            //th second input is where we are getting the items to join in this case it from the integer list

            Console.WriteLine("You are correct! " + userInput + " is on the list and its indices are: " + string.Join(", ", matchingIndices));
        }
        //if no matches are found from our guess the below is run
        else
        {
            Console.WriteLine("The guess you made is incorrect and is not on the list");
        }


        //ASSIGNMENT PART 6

        //creates a list that contains a string of letters
        List<string> letters = new List<string>() { "A", "B", "C", "D", "C" };
        
        //creates an empty list that can contain string elements
        List<string> repeatLetters = new List<string>(); 

        //goess through ever element in the letter string and does whats in the {}
        foreach(string letter in letters)
        {
            //writes out each element
            Console.WriteLine(letter);
            //if currently empty repeatLetters list contains any element that is in the oringal letter list the code in {} runs.
            if (repeatLetters.Contains(letter))
            {
                Console.WriteLine("This letter has been repeated");
            }
            //if ti does not this is run
            else
            {
                Console.WriteLine("This letter is unique");
            }
            //This line add each string element from the letter list to the repeatLetter list
            repeatLetters.Add(letter);
        }

        Console.ReadLine();
        }

    }

