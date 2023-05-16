using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon
{
    public abstract class Player
    {
        public string Name {  get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public abstract void Attack(Player target);
        public void PrintStats()
        {
            Console.WriteLine($"Здоровье: {Health}");
            Console.WriteLine($"Урон: {Damage}");
        }
    }
}
