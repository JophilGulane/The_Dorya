using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public abstract class GameCharacter
    {
        private string _name;
        private int _level;
        private int _health;
        private int _mana;
        private int _strength;
        private int _intelligence;


        public string Name
        {
            get => _name;
            protected set => _name = value;
        }

        public int Level
        {
            get => _level;
            protected set
            {
                if (value > 0)
                    _level = value;
            }
        }

        public int Health
        {
            get => _health;
            set
            {
                if (value >= 0)
                    _health = value;
            }
        }

        public int Mana
        {
            get => _mana;
            protected set
            {
                if (value >= 0)
                    _mana = value;
            }
        }

        public int Strength
        {
            get => _strength;
            protected set
            {
                if (value >= 0)
                    _strength = value;
            }
        }

        public int Intelligence
        {
            get => _intelligence;
            protected set
            {
                if (value >= 0)
                    _intelligence = value;
            }
        }

        public GameCharacter(string _name, int _level, int _health, int _mana, int _strength, int _intelligence)
        {
            Name = _name;
            Level = _level;
            Health = _health;
            Mana = _mana;
            Strength = _strength;
            Intelligence = _intelligence;
        }

        public abstract int Attack();
        public abstract int Defend(int damage);
        public abstract string LevelUp();

        public abstract string CheckStats();
    }
}
