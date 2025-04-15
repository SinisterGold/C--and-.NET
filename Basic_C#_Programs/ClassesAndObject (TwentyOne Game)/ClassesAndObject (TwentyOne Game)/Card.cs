using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject__TwentyOne_Game
{
    public struct Card
    {
        public Suit Suit { get; set; } //properties
        public Face Face { get; set; }
    }
    public enum Suit //these are enums meaning suit and face can only have these specific values
    {
        Clubs,
        Diamobds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
