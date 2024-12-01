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
        private int _energyCost;
        private int _damage;
        private int _buff;
        private string _description;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int EnergyCost
        {
            get => _energyCost;
            set
            {
                if (value >= 0)
                    _energyCost = value;
            }
        }
        public int Damage
        {
            get => _damage;
            set
            {
                if (value > 0)
                    _damage = value;
            }
        }
        public int Buff
        {
            get => _buff;
            set
            {
                if (value > 0)
                    _buff = value;
            }
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public Skills(string _name, int _energyCost, int _damage, int buff, string _description)
        {
            Name = _name;
            EnergyCost = _energyCost;
            Damage = _damage;
            Buff = _buff;
            Description = _description;
        }


        public abstract int UseBasicSkill();
        public abstract int UseUltimateSkill();
        public abstract int UseResortSkill();
        public abstract int UseBuffSkill();

    }

}
