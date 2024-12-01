using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class Mage : GameCharacter
    {
        private int attackPower;
        private int intelligence;
        private int mana;

        public int AttackPower
        {
            get => attackPower;
            private set
            {
                if (value >= 0)
                    attackPower = value;
            }
        }

        public int Intelligence
        {
            get => intelligence;
            private set
            {
                if (value >= 0) 
                    intelligence = value;

            }
        }

        public int Mana
        {
            get => mana;
            set
            {
                if (value >= 0)
                    mana = value;
            }
        }

        public Mage(string _name, int _level, int _health, int _defense)
            : base(_name, _level, _health, _defense)
        {
            AttackPower = 7 + (3 *_level);
            Mana = 35 + (10 * _level);
            Intelligence = 3 + 2 * _level;
        }

        public override int Attack()
        {
            int magicDamage = attackPower * (Intelligence / 4);
            bool burningEffect = new Random().Next(100) < 25;

            if (burningEffect)
            {
                return magicDamage += 10;
            }
                return magicDamage;

        }

        public override int Defend(int damage)
        {
            int damageReduction = Defense / 4;
            bool evaded = new Random().Next(100) < 20;

            if (evaded)
            {
                return damage = 0;
            }
                return damage - damageReduction;
        }

        public override string LevelUp()
        {
            return ($"<--- {Name} leveled up! New stats --->\n" +
                    $"Level: {Level} --> {++Level}\n" +
                    $"Health: {Health} --> {Health = (10 * Level)}\n" +
                    $"Intelligence: {Intelligence} --> {Intelligence += 2}\n" +
                    $"Mana: {Mana} --> {Mana += 10}\n" +
                    $"SpellPower: {AttackPower} --> {AttackPower += 3}");
        }

        public override string CheckStats()
        {
            return ($"Names: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"Health: {Health}\n" +
                   $"AttackPower: {AttackPower}\n" +
                   $"Intelligence: {Intelligence}\n" +
                   $"Mana: {Mana}") + "\n";

        }
    }
}
