using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallingAssignment
{
    public class Calculations
    {
        //create three methods that take one integer parameter and retrun an integer
        public static int Heal(int lifepowder)
        {
            int hitpoints = lifepowder + 10;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy_str = 25;
            int element_mt = -2;
            int defensecharm_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (element_mt + defensecharm_bonus) - defense) * crit_coeff;
            return damage;
        }
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int element_dmg = 8;
            int attackcharm_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (element_dmg + attackcharm_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}
