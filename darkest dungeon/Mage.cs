using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon
{
    public class Mage : Player
    {
        public Mage() 
        {
            Name = "Маг";
            Health = 100;
            Damage = 20;
        }
        public override void Attack(Player target)
        {
            if (target is Warrior)
            {
                target.Health -= (int)(Damage * 1.5);
            }
            else
            {
                target.Health -= Damage;
            }
        }
    }
}
