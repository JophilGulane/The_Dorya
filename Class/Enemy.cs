using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class Enemy
    {
        public string Name { get; private set; }

        public int Level { get; set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Enemy(string name, int level, int health, int attackPower)
        {
            Name = name;
            Level = level;
            Health = health * level;
            AttackPower = attackPower * (level + 1 / 2);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public int Attack(GameCharacter target)
        {
            int damage = this.AttackPower;
            return damage;
        }
    }
}
