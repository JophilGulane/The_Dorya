using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_GUI.Class
{
    public class FireBall : Skills
    {
        public FireBall() : base("Fire Ball", 10, 0, 30, 0, "Mage's basic attack.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class Explosion : Skills
    {
        public Explosion() : base("Sword of Justice", 20, 0, 80, 0, "Mage's ulitimate attack.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class StickPummel : Skills
    {
        public StickPummel() : base("Stick Pummel", 0, 0, 20, 0, "No more mister nice guy.")
        {

        }
        public override int Use()
        {
            return Damage;
        }
    }
    public class ArmamentEnchant : Skills
    {
        public ArmamentEnchant() : base("ArmamentEnchant", 0, 0, 0, 20, "Imagine if I had a real weapon.")
        {

        }
        public override int Use()
        {
            return Buff;
        }
    }
}
