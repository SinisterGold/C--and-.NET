using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject__TwentyOne_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //If you need help when reading this in the future rewatch Classes and Objects 3 part video
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); 


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //shuffle method; for the out parameter watch "More on Methods" video
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>(); //we create a templist that will contain shuffled indexes
                Random random = new Random(); //this is the built in random method we call and name random

                while (deck.Cards.Count > 0) //we make a while loop that says will the card cound in our list called deck is greater then 0 to this
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //we make a random number using 0 to deck list max card count being 52
                    TempList.Add(deck.Cards[randomIndex]); // we then take that random number ad add it to the temp list
                    deck.Cards.RemoveAt(randomIndex); //we then remove that same random number we created from the deck list so now it has one less card
                }
                deck.Cards = TempList; //after that repeats for all 52 cards we then take that random list of cards and make that now equal our deck list
            }

            return deck; //this just returns us that new deck

        }

        //public static Deck Shuffle(Deck deck, int times) //This is called method overloading watch video "More on Methods" for indepth explination
        //{
        //    for (int i  = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
