using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Arena_Game_2._1.Weapon;
using static System.Net.Mime.MediaTypeNames;

namespace Arena_Game_2._1
{
    internal class Program
    {

        class ConsoleBattleListener : IArenaBattleListener
        {
            public void OnBattleTurn(BattleEvent e)
            {
                Console.WriteLine($"{e.Attacker.Name} attacks {e.Defender.Name} " +
                    $"for {e.Damage}.");
            }
        }
        static void Main(string[] args)
        {
            Weapon flamingSword = new Weapon("Fire sword", 20, new FireAbility(20, 30));
            Weapon lightingSword = new Weapon("Lighting sword", 10, new LightingAbility(30, 40));
            Weapon shotgun = new Weapon("Shotgun", 10, new BlastAbility(10, 25));

            Hero one = new Knight("Sir Lancelot", flamingSword);
            Hero two = new Rogue("Robih Hood", lightingSword);
            Hero three = new Barbarian("John", shotgun);
            Hero four = new Mage("Arhimed", flamingSword);


            Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
            Arena arena = new Arena(one, two);
            arena.BattleListener = new ConsoleBattleListener();
            Hero winner = arena.Battle();
            Console.WriteLine($"Winner is: {winner.Name}");

            Console.WriteLine();
            Console.WriteLine($"Arena fight between: {three.Name} and {four.Name}");
            Arena arena2 = new Arena(three, four);
            arena2.BattleListener = new ConsoleBattleListener();
            Hero winner2 = arena2.Battle();
            Console.WriteLine($"Winner is: {winner2.Name}");



            Console.ReadLine();

        }
    }
}
