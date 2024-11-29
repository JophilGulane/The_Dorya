using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public abstract class Skills
    {
        private string _name;
        private int _manaCost;
        private int _staminaCost;
        private int _damage;
        private int _buff;
        private string _description;

        public string Name
        {
            get => _name;
            protected set => _name = value;
        }
        public int ManaCost
        {
            get => _manaCost;
            protected set
            {
                if (value > 0)
                    _manaCost = value;
            }
        }
        public int StaminaCost
        {
            get => _staminaCost;
            protected set
            {
                if (value > 0)
                    _staminaCost = value;
            }
        }
        public int Damage
        {
            get => _damage;
            protected set
            {
                if (value > 0)
                    _damage = value;
            }
        }
        public int Buff
        {
            get => _buff;
            protected set
            {
                if (value > 0)
                    _buff = value;
            }
        }
        public string Description
        {
            get => _description;
            protected set => _description = value;
        }
        public Skills(string _name, int _manaCost, int _staminaCost, int _damage, int buff, string _description)
        {
            Name = _name;
            ManaCost = _manaCost;
            StaminaCost = _staminaCost;
            Damage = _damage;
            Buff = _buff;
            Description = _description;
        }

        public abstract int Use();
    }

}
