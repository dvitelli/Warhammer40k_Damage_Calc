using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            for (int i = 0; i < attacks; i++)
            {
                if (rnd.Next(1, 7) >= (weaponSkill))
                {

                    attacksHit++;
                }
            }

            //System.Diagnostics.Debug.Write("Attacks hit:" +attacksHit);
            return attacksHit;

        }

        public int Wounds(SheetDummy dummy)
        {
            int wounds = 0;
            int toughness = ToughnessCheck(dummy.Toughness); ;
            int attacksHit = AttacksHit();
            Random rnd = new Random();

            for (int i = 0; i < attacksHit; i++)
            {
                if (rnd.Next(1, 7) >= (toughness))
                {

                    wounds++;
                }
            }

            System.Diagnostics.Debug.Write("Attacks hit: " + attacksHit + " Wounds: " + wounds + " ");
            return wounds;

        }

        public int AttackSaved(int woundsIn, SheetDummy dummy)
        {
            int saves = 0;
            int saveOn = dummy.Save + AP;

            int wounds = woundsIn;
            Random rnd = new Random();

            if (saveOn > 6)
            {
                return 0 + FeelNoPain(woundsIn, dummy);
            }
            if (saveOn < dummy.InvulnSave)
            {
                saveOn = dummy.InvulnSave;
            }

            for (int i = 0; i < wounds; i++)
            {
                if (rnd.Next(1, 7) >= (saveOn))
                    saves++;
            }

            //System.Diagnostics.Debug.WriteLine("Space Marines save on:" + saveOn);
            System.Diagnostics.Debug.Write(" Saves: " + saves + " ");
            return saves + FeelNoPain((woundsIn - saves), dummy);
        }

        public int ToughnessCheck(int sheetToughness)
        {
            int toughness = sheetToughness;

            if (strength >= (toughness * 2))
            {
                //System.Diagnostics.Debug.WriteLine("Toughness:" + 2);
                return 2;
            }
            if (strength > toughness)
            {
                //System.Diagnostics.Debug.WriteLine("Toughness:" + 3);
                return 3;
            }
            if (strength == toughness)
            {
                //System.Diagnostics.Debug.WriteLine("Toughness:" + 4);
                return 4;
            }
            if (strength <= (toughness * .5))
            {
                //System.Diagnostics.Debug.WriteLine("Toughness:" + 6);
                return 6;
            }
            if (strength < toughness)
            {
                //System.Diagnostics.Debug.WriteLine("Toughness:" + 5);
                return 5;
            }

            return 0;

        }

        public int FeelNoPain(int woundsIn, SheetDummy dummy)
        {
            int saves = 0;
            int saveOn = dummy.FeelNoPain;

            if (woundsIn <= 0)
            {
                return 0;
            }

            int wounds = woundsIn;
            Random rnd = new Random();

            if (saveOn > 6)
            {
                return 0;
            }

            for (int i = 0; i < wounds; i++)
            {
                if (rnd.Next(1, 7) >= (saveOn))
                    saves++;
            }

            return saves;
        }

        public void testCalc(SheetDummy dummy)
        {
            int damageDone = 0;
            for (int i = 0; i < 10000; i++)
            {
                int wounds = Wounds(dummy);
                int currentRoll = ((wounds - AttackSaved(wounds, dummy)) * this.damage);
                damageDone += currentRoll;

                System.Diagnostics.Debug.WriteLine("Damage Calc " + i + ": " + currentRoll);

            }

            //System.Diagnostics.Debug.WriteLine("Damage Done: "+damageDone);

            DamagePrint(dummy, damageDone);

        }

        private void DamagePrint(SheetDummy dummy, int damageDone)
        {
            int averageDamage = (damageDone / 10000);
            int averageHits = (averageDamage / damage);
            System.Diagnostics.Debug.WriteLine("Average Damage Done: " + averageDamage);

            if (damage == 1)
            {
                System.Diagnostics.Debug.WriteLine(dummy.Name + " killed: " + (averageDamage / dummy.HP));
            }
            else if (damage >= dummy.HP)
            {
                System.Diagnostics.Debug.WriteLine(dummy.Name + " killed: " + (averageHits));
            }
        }
    }

}
