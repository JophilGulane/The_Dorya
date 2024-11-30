using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class MageSkills : Skills
    {
        public MageSkills() : base("", 0, 0, 0, "")
        {

        }
        public override int UseBasicSkill()
        {
            Name = "Fire ball";
            EnergyCost = 10;
            Damage = 30;
            Buff = 0;
            Description = "Mage's basic attack.";
            return Damage;
        }
        public override int UseUltimateSkill()
        {
            Name = "Explosion";
            EnergyCost = 20;
            Damage = 80;
            Buff = 0;
            Description = "Mage's ultimate attack.";
            return Damage;
        }
        public override int UseResortSkill()
        {
            Name = "Stick Pummel";
            EnergyCost = 0;
            Damage = 20;
            Buff = 0;
            Description = "No more mister nice guy.";
            return Damage;
        }
        public override int UseBuffSkill()
        {
            Name = "Armament Enchant";
            EnergyCost = 20;
            Damage = 0;
            Buff = 20;
            Description = "Imagine if I had a real weapon.";
            return Buff;
        }
    }
}
