using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class Warrior : GameCharacter
    {
        private int armor;

        public int Armor
        {
            get => armor;
            private set
            {
                if (value >= 0)
                    armor = value;
            }
        }

        public Warrior(string _name, int _level, int _health, int _strength)
            : base(_name, _level, _health, 0, _strength, 0)
        {
            Armor = 10;
        }

        public override int Attack()
        {
            int baseDamage = Strength * 2;
            bool isCritical = new Random().Next(100) < 20;
            int finalDamage = isCritical ? baseDamage * 2 : baseDamage;

            Console.WriteLine($"{Name} attacks for {finalDamage} damage{(isCritical ? " Critical Hit!! " : "")}.");
            Console.WriteLine();
            return finalDamage;
        }

        public override int Defend(int damage)
        {
            int damageReduction = Armor / 2;
            bool blocked = new Random().Next(100) < 15;

            Console.WriteLine((blocked) ? ($"{Name} blocked the attack completely!") : ($"{Name} reduced incoming damage by {damageReduction}."));
            Console.WriteLine();

            return blocked ? 0 : damageReduction;
        }

        public override string LevelUp()
        {
            return ($"<--- {Name} leveled up! New stats --->\n" +
                              $"Level: {Level} --> {++Level}\n" +
                              $"Strength: {Strength} --> {Strength += 5}\n" +
                              $"Health: {Health} --> {Health += 20}\n" +
                              $"Armor: {Armor} --> {Armor += 2}");
        }

        public override string CheckStats()
        {
            return ($"Names: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"Strength: {Strength}\n" +
                   $"Health: {Health}\n" +
                   $"Armor: {Armor}") + "\n";

        }

    }

}
