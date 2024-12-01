using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_Character_GUI.Class
{
    public class WarriorSkills : Skills
    {
        SoundSystem soundSystem = new SoundSystem();
        public WarriorSkills(string _name, int _energyCost, int _damage, int _buff, string _description) : base(_name, _energyCost, _damage, _buff, _description)
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
            soundSystem.PlaySound(@"SoundFX\SwordSlash.wav");
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
            soundSystem.PlaySound(@"SoundFX\SwordOfJustice.wav");
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
            soundSystem.PlaySound(@"SoundFX\SwordBasicAttack.wav");
            return Damage;
        }
        public override int UseBuffSkill()
        {
            Name = "Desert Eagle";
            ManaCost = 0;
            StaminaCost = 20;
            Damage = 0;
            Buff = 20;
            Description = "Buff the sword";
            return Buff;
        }
    } 
}
