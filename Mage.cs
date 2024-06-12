using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arena_Game_2._1
{
    internal class Mage : Hero
    {
        private const int ExtraMagicDamageChance = 20;
        private const int ManaRegenChance = 15;
        private int mana;

        public Mage(string name, Weapon weapon) : base(name, weapon)
        {
            mana = 100;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ExtraMagicDamageChance))
            {
                attack += 50;
            }

            if (ThrowDice(ManaRegenChance))
            {
                mana += 20;
                Console.WriteLine($"{Name} regenerates 20 mana.");
            }

            return attack;
        }
    }
}
