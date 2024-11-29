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
        private int _defense;

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
                    _health = value;
            }
        }

        public int Defense
        {
            get => _defense;
            set
            {
                if (value >= 0)
                    _defense = value;
            }
        }

        public GameCharacter(string _name, int _level, int _health, int _defense)
        {
            Name = _name;
            Level = _level;
            Health = _health;
            Defense = _defense;
        }

        public abstract int Attack();
        public abstract int Defend(int damage);
        public abstract string LevelUp();
        public abstract string CheckStats();
    }
}
