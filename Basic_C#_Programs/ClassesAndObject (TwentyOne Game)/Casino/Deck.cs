using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{ 
    public class Deck
    {
        
        public Deck() //constructor
        {
             Cards = new List<Card>();

            for (int i = 0; i <13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; } //property

        public void Shuffle(int times = 1) //shuffle method
                                           //For the out parameter watch "More on Methods" video                                         
        {

            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>(); //we create a templist that will contain shuffled indexes
                Random random = new Random(); //this is the built in random method we call and name random

                while (Cards.Count > 0) //we make a while loop that says will the card cound in our list called deck is greater then 0 to this
                {
                    int randomIndex = random.Next(0, Cards.Count); //we make a random number using 0 to deck list max card count being 52
                    TempList.Add(Cards[randomIndex]); // we then take that random number ad add it to the temp list
                    Cards.RemoveAt(randomIndex); //we then remove that same random number we created from the deck list so now it has one less card
                }
                Cards = TempList; //after that repeats for all 52 cards we then take that random list of cards and make that now equal our deck list
            }
           
        }
    }
}
