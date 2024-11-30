using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class WarriorSkills : Skills
    {
        public WarriorSkills(string _name, int _energyCost, int _damage, int _buff, string _description) : base(_name, _energyCost, _damage, _buff, _description)
        {

        }
        public override int UseBasicSkill()
        {
            Name = "Sword Slash";
            EnergyCost = 10;
            Damage = 30;
            Buff = 0;
            Description = "Warrior's basic attack.";
            return Damage;
        }
        public override int UseUltimateSkill()
        {
            Name = "Sword of Justice";
            EnergyCost = 20;
            Damage = 80;
            Buff = 0;
            Description = "Warrior's ultimate attack.";
            return Damage;
        }
        public override int UseResortSkill()
        {
            Name = "Desert Eagle";
            EnergyCost = 0;
            Damage = 20;
            Buff = 0;
            Description = "Parry this you filthy casual";
            return Damage;
        }
        public override int UseBuffSkill()
        {
            Name = "Sword Aura";
            EnergyCost = 20;
            Damage = 0;
            Buff = 20;
            Description = "Buff the sword";
            return Buff;
        }
    } 
}
