using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_2._1
{
    public interface IWeaponAbility
    {
        int Apply(int damage);
    }

    public class Weapon
    {
        public string Name { get; private set; }
        public int BonusDamage { get; private set; }
        public IWeaponAbility Ability { get; private set; }

        public Weapon(string name, int bonusdamage, IWeaponAbility ability = null)
        {
            Name = name;
            BonusDamage = bonusdamage;
            Ability = ability;
        }
        public int ModifyAttack(int baseDamage)
        {
            int damage = baseDamage + BonusDamage;
            if (Ability != null)
            {
                damage = Ability.Apply(damage);
            }
            return damage;
        }

        public class FireAbility : IWeaponAbility
        {
            private int chance;
            private int extraDamage;

            public FireAbility(int chance, int extraDamage)
            {
                this.chance = chance;
                this.extraDamage = extraDamage;
            }

            public int Apply(int damage)
            {
                Random rand = new Random();
                if (rand.Next(100) < chance)
                {
                    return damage + extraDamage;
                }
                return damage;
            }

        }

        public class LightingAbility : IWeaponAbility
        {
            private int chance;
            private int extraDamage;

            public LightingAbility(int chance, int extraDamage)
            {
                this.chance = chance;
                this.extraDamage = extraDamage;
            }

            public int Apply(int damage)
            {
                Random rand = new Random();
                if (rand.Next(100) < chance)
                {
                    return damage + extraDamage;
                }
                return damage;
            }
        }

        public class BlastAbility : IWeaponAbility
        {
            private int chance;
            private int extraDamage;

            public BlastAbility(int chance, int extraDamage)
            {
                this.chance = chance;
                this.extraDamage = extraDamage;
            }

            public int Apply(int damage)
            {
                Random rand = new Random();
                if (rand.Next(100) < chance)
                {
                    return damage + extraDamage;
                }
                return damage;
            }

        }

    }
}

