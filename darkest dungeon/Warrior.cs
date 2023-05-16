using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon
{
    public class Warrior : Player
    {
        public Warrior() 
        {
            Name = "Воин";
            Health = 150;
            Damage = 15;
        }
        public override void Attack(Player target)
        {
            if (target is Hunter)
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
