using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encounter a Wild Deviljo!");
            Console.WriteLine("Please input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = Calculations.Defense(defense);
            Console.WriteLine("The Deviljo strikes first! You take " + enemy_damage + " points of damage.");
            Console.WriteLine("Your fellow hunter is nearby and attempts to heal you.");
            Console.WriteLine("How many life powders should they use?:");
            int lifepowder = Convert.ToInt32(Console.ReadLine());
            int hp = Calculations.Heal(lifepowder);
            Console.WriteLine("You have healed for " + hp + " HP.");
            Console.WriteLine("Its your turn to attack! How much strength do you have?:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = Calculations.Attack(strength);
            Console.WriteLine("You've landed a devestating blow and dealt " + damage + " points of damage!");
            Console.ReadLine();


        }
    }
}
