using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warhammer40kDamage
{
    class WeaponObject
    {

        private string weaponName;
        private string weaponType;
        private int strength;
        private int weaponSkill;
        private int attacks;
        private int ap;
        private int damage;

        public WeaponObject(string weaponName, string weaponType, int strength, int weaponSkill, int attacks, int ap, int damage)
        {
            this.weaponName = weaponName;
            this.weaponType = weaponType;
            this.strength = strength;
            this.weaponSkill = weaponSkill;
            this.attacks = attacks;
            this.ap = ap;
            this.damage = damage;

        }

        public string WeaponName { get { return weaponName; } }
        public string WeaponType { get { return weaponType; } }
        public int Strength { get { return strength; } }
        public int WeaponSkill { get { return weaponSkill; } }
        public int Attacks { get { return attacks; } }
        public int AP { get { return ap; } }
        public int Damage { get { return damage; } }

        public void printWeapon()
        {
            System.Diagnostics.Debug.WriteLine(weaponName);
            System.Diagnostics.Debug.WriteLine(weaponType);
            System.Diagnostics.Debug.WriteLine(strength);
            System.Diagnostics.Debug.WriteLine(weaponSkill);
            System.Diagnostics.Debug.WriteLine(attacks);
            System.Diagnostics.Debug.WriteLine(ap);
            System.Diagnostics.Debug.WriteLine(damage);
            
        }

        public int AttacksHit()
        {

            int attacksHit = 0;
            Random rnd = new Random();

            
            for(int i = 0; i < attacks; i++)
            {
                if(rnd.Next(1, 7) >= (weaponSkill))
                {
                 
                    attacksHit++;
                }
            }

            System.Diagnostics.Debug.WriteLine("Attacks hit:" +attacksHit);
            return attacksHit;

        }

        public int Wounds()
        {
            int wounds = 0;
            int toughness = ToughnessCheck();
            int attacksHit = AttacksHit();
            Random rnd = new Random();

            for (int i = 0; i < attacksHit; i++)
            { 
                if (rnd.Next(1, 7) >= (toughness))
                {
                    
                    wounds++;
                }
            }

            System.Diagnostics.Debug.WriteLine("Wounds:" + wounds);
            return wounds;

        }

        public int AttackSaved()
        {
            int saves = 0;
            int saveOn = 4;
            int wounds = Wounds();
            Random rnd = new Random();

            for(int i = 0; i < wounds; i++)
            {
                if(rnd.Next(1, 7) >= (saveOn))
                saves++;
            }

            System.Diagnostics.Debug.WriteLine("Space Marines save on:" + saveOn);
            System.Diagnostics.Debug.WriteLine("Saves:" + saves);
            return saves;
        }

        public int ToughnessCheck()
        {
            int toughness = 4;

            if(strength >= (toughness * 2))
            {
                System.Diagnostics.Debug.WriteLine("Toughness:" + 2);
                return 2;
            }
            if(strength > toughness)
            {
                System.Diagnostics.Debug.WriteLine("Toughness:" + 3);
                return 3;
            }
            if (strength == toughness)
            {
                System.Diagnostics.Debug.WriteLine("Toughness:" + 4);
                return 4;
            }
            if(strength <= (toughness * .5))
            {
                System.Diagnostics.Debug.WriteLine("Toughness:" + 6);
                return 6;
            }
            if(strength < toughness)
            {
                System.Diagnostics.Debug.WriteLine("Toughness:" + 5);
                return 5;
            }

            return 0;
            
        }

        public void testCalc()
        {   
            int damageDone = (Wounds() - AttackSaved()) * damage;
            System.Diagnostics.Debug.WriteLine("Damage:" + damageDone);

        }
    }

    class UnitSheet { }

    class Damage { }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
