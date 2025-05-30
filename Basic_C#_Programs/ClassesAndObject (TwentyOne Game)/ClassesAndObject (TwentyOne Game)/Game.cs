﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject__TwentyOne_Game
{
    public  abstract class Game
    {
        public List<Player> Players { get; set; } //properties
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();
        public virtual void ListPlayers() //list of players method
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
