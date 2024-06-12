using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arena_Game_2._1
{
    internal class Barbarian : Hero
    {
        private const int CriticalHitChance = 25;
        private const int CriticalHitMultiplier = 200;

        public Barbarian(string name, Weapon weapon) : base(name, weapon) { }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CriticalHitChance))
            {
                attack = attack * CriticalHitMultiplier / 100;
                Console.WriteLine($"{Name} lands a critical hit!");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }
}
