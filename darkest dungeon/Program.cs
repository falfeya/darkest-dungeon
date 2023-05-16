using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Darkest Dungeon!");
            Console.WriteLine("Выберите класс: ");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Воин");
            Console.WriteLine("3. Охотник");
            int playerChoice = int.Parse(Console.ReadLine());
            Player player;
            switch (playerChoice)
            {
                case 1:
                    player = new Mage();
                    break;
                case 2:
                    player= new Warrior();
                    break;
                case 3:
                    player= new Hunter();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор. Будет использован класс по умолчанию - Воин.");
                    player = new Warrior();
                    break;
            }
            Console.WriteLine($"Вы выбрали класс: {player.Name}");
            while ( true )
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("2. Завершить игру");
                int actionChoice = int.Parse(Console.ReadLine());
                if ( actionChoice == 1 ) 
                {
                    Console.WriteLine("Выберите цель атаки:");
                    Console.WriteLine("1. Маг");
                    Console.WriteLine("2. Воин");
                    Console.WriteLine("3. Охотник");
                    int targetChoice = int.Parse(Console.ReadLine());
                    Player target;
                    switch (targetChoice) 
                    {
                        case 1:
                            target = new Mage();
                            break;
                        case 2:
                            target = new Warrior();
                            break;
                        case 3:
                            target = new Hunter();
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор. Целью атаки будет выбран Маг.");
                            target = new Mage();
                            break;
                    }
                    Console.WriteLine($"Вы атакуете {target.Name}");
                    player.Attack( target );
                    target.PrintStats();
                }
                else if (actionChoice  == 2 ) 
                {
                    Console.WriteLine("Конец игры.");
                    break;
                }
            }
        }
    }
}
