using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class SwordSlash : Skills
    {
        public SwordSlash() : base("Sword Slash", 0, 10, 30, 0, "Warrior's basic attack.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class SwordofJustice : Skills
    {
        public SwordofJustice() : base("Sword of Justice", 0, 20, 80, 0, "Warrior's ulitimate attack.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class DesertEagle : Skills
    {
        public DesertEagle() : base("Desert Eagle", 0, 0, 20, 0, "Parry this you filthy casual.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class SwordAura : Skills
    {
        public SwordAura() : base("Sword Aura ", 0, 0, 0, 20, "I am the bone of my sword.")
        {

        }
        public override int Use()
        {
            return Buff;
        }
    }
}
