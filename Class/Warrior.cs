using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class Warrior : GameCharacter
    {
        private int attackDamage;
        private int strength;
        private int stamina;

        public int AttackDamage
        {
            get => attackDamage;
            private set
            {
                if (value >= 0)
                    attackDamage = value;
            }
        }

        public int Strength
        {
            get => strength;
            private set
            {
                if (value >= 0)
                    strength = value;

            }
        }

        public int Stamina
        {
            get => stamina;
            private set
            {
                if (value >= 0)
                    stamina = value;
            }
        }
        public Warrior(string _name, int _level, int _health, int _armor)
            : base(_name, _level, _health, _armor)
        {
            AttackDamage = 7 + 3 * _level;
            Stamina = 35 + (10 * _level);
            Strength = 3 + 2 * _level;
        }

        public override int Attack()
        {
            int baseDamage = AttackDamage * (Strength / 4);
            int criticalDamage = 10;
            bool isCritical = new Random().Next(100) < 20;

            if (isCritical)
            {
                return baseDamage + criticalDamage;
            }

            return baseDamage;
        }

        public override int Defend(int damage)
        {
            int damageReduction = Defense / 4;
            bool blocked = new Random().Next(100) < 15;

            if (blocked)
            {
                return damage = 0;
            }

            return damage - damageReduction;
        }

        public override string LevelUp()
        {
            return ($"<--- {Name} leveled up! New stats --->\n" +
                    $"Level: {Level} --> {++Level}\n" +
                    $"Intelligence: {Strength} --> {Strength += 2}\n" +
                    $"Mana: {Stamina} --> {Stamina += 10}\n" +
                    $"SpellPower: {AttackDamage} --> {AttackDamage += 3}");
        }

        public override string CheckStats()
        {
            return ($"Names: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"Strength: {Strength}\n" +
                   $"Health: {Health}\n" +
                   $"AttackDamage: {AttackDamage}") + "\n";

        }

    }

}
