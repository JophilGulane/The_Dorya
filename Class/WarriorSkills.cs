using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class WarriorSkills : Skills
    {
        public WarriorSkills() : base("", 0, 0, 0, 0, "")
        {

        }
        public override int UseBasicSkill()
        {
            Name = "Sword Slash";
            ManaCost = 0;
            StaminaCost = 10;
            Damage = 30;
            Buff = 0;
            Description = "Warrior's basic attack.";
            return Damage;
        }
        public override int UseUltimateSkill()
        {
            Name = "Sword of Justice";
            ManaCost = 0;
            StaminaCost = 20;
            Damage = 80;
            Buff = 0;
            Description = "Warrior's ultimate attack.";
            return Damage;
        }
        public override int UseResortSkill()
        {
            Name = "Desert Eagle";
            ManaCost = 0;
            StaminaCost = 0;
            Damage = 20;
            Buff = 0;
            Description = "Parry this you filthy casual";
            return Damage;
        }
        public override int UseBuffSkill()
        {
            Name = "Desert Eagle";
            ManaCost = 0;
            StaminaCost = 20;
            Damage = 0;
            Buff = 20;
            Description = "Parry this you filthy casual";
            return Buff;
        }
    } 
}
