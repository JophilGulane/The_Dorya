using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class MageSkills : Skills
    {
        SoundSystem soundSystem = new SoundSystem();
        public MageSkills(string _name, int _energyCost, int _damage, int _buff, string _description) : base(_name, _energyCost, _damage, _buff, _description)
        {

        }
        public override int UseBasicSkill()
        {
            Name = "Fire ball";
            ManaCost = 10;
            StaminaCost = 0;
            Damage = 30;
            Buff = 0;
            Description = "Mage's basic attack.";
            soundSystem.PlaySound(@"SoundFX\FireBall.wav");
            return Damage;
        }
        public override int UseUltimateSkill()
        {
            Name = "Explosion";
            ManaCost = 20;
            StaminaCost = 0;
            Damage = 80;
            Buff = 0;
            Description = "Mage's ultimate attack.";
            soundSystem.PlaySound(@"SoundFX\Explosion.wav");
            return Damage;
        }
        public override int UseResortSkill()
        {
            Name = "Stick Pummel";
            ManaCost = 0;
            StaminaCost = 0;
            Damage = 20;
            Buff = 0;
            Description = "No more mister nice guy.";
            soundSystem.PlaySound(@"SoundFX\HitSound.wav");
            return Damage;
        }
        public override int UseBuffSkill()
        {
            Name = "Armament Enchant";
            ManaCost = 20;
            StaminaCost = 0;
            Damage = 0;
            Buff = 20;
            Description = "Imagine if I had a real weapon.";
            soundSystem.PlaySound(@"SoundFX\ArmamentEnchantment.wav");
            return Buff;
        }
    }
}
