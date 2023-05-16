using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon
{
    public class Hunter : Player
    {
        public Hunter() 
        {
            Name = "Охотник";
            Health = 120;
            Damage = 10;
        }
        public override void Attack(Player target)
        {
            if (target is Mage)
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
