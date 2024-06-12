using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_2._1
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }
        public Weapon Weapon { get; private set; }


        private Random rand = new Random();
        public Hero(string name, Weapon weapon)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            Weapon = weapon;
        }

        public virtual int Attack()
        {
            int baseAttack = (Strength * rand.Next(80, 121)) / 100;
            return Weapon != null ? Weapon.ModifyAttack(baseAttack) : baseAttack;

        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = rand.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
