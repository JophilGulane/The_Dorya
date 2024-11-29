using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class Mage : GameCharacter
    {
        private int spellPower;

        public int SpellPower
        {
            get => spellPower;
            private set
            {
                if (value >= 0)
                    spellPower = value;
            }
        }

        public Mage(string _name, int _level, int _health, int _mana, int _intelligence)
            : base(_name, _level, _health, _mana, 0, _intelligence)
        {
            SpellPower = 10;
        }

        public override int Attack()
        {
            int magicDamage = Intelligence * 3 + SpellPower;
            bool burningEffect = new Random().Next(100) < 25;

            Console.WriteLine($"{Name} casts a spell for {magicDamage} magic damage{(burningEffect ? " and applies a burning effect!" : "")}.");
            Console.WriteLine();

            return magicDamage;
        }

        public override int Defend(int damage)
        {
            int damageReduction = Mana / 4;
            bool evaded = new Random().Next(100) < 20;
            int totalDamage = 0;

            Console.WriteLine((evaded) ? ($"{Name} evaded the attack!") : ($"{Name} reduced incoming damage by {damageReduction}."));
            Console.WriteLine();

            if (evaded)
            {

            }

            return totalDamage;
        }

        public override string LevelUp()
        {
            return ($"<--- {Name} leveled up! New stats --->\n" +
                              $"Level: {Level} --> {++Level}\n" +
                              $"Intelligence: {Intelligence} --> {Intelligence += 5}\n" +
                              $"Mana: {Mana} --> {Mana += 15}\n" +
                              $"SpellPower: {SpellPower} --> {SpellPower += 3}");
        }

        public override string CheckStats()
        {
            return ($"Names: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"Intelligence: {Intelligence}\n" +
                   $"Health: {Health}\n" +
                   $"SpellPower: {SpellPower}") + "\n";

        }
    }
}
