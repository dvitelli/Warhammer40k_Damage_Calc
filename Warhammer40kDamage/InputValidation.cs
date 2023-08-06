using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warhammer40kDamage
{
     class InputCheck
    {
        public InputCheck(string weaponName, string strength, string weaponSkill, string attacks, string ap, string damage, string dummy) {

                WeaponNameCheck(weaponName); //check weapon name
                StrengthCheck(strength);
                WeaponSkillCheck(weaponSkill);
                AttacksCheck(attacks);
                APCheck(ap);
                DamageCheck(damage);
                DummyCheck(dummy);

        }
        public void WeaponNameCheck(string weaponName) {

                if (string.IsNullOrEmpty(weaponName))
                {
                    throw new Exception("No name entered. Please enter a weapon name.");
                }
        
            
        }
        public void StrengthCheck(string strength) {

            if(string.IsNullOrEmpty(strength))
            {
                throw new Exception("No strength was entered. Please enter a strength value.");
            }

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(strength))
            {
                throw new Exception("Strength has to be a numerical value. Please enter a numerical value for strength.");
            }

        }
        public void WeaponSkillCheck(string weaponSkill) {

            if (string.IsNullOrEmpty(weaponSkill))
            {
                throw new Exception("No weapon skill was entered. Please enter a weapon skill value.");
            }

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(weaponSkill))
            {
                throw new Exception("Weapon skill has to be a numerical value. Please enter a numerical value for weapon skill.");
            }


        }
        public void AttacksCheck(string attacks) {

            if (string.IsNullOrEmpty(attacks))
            {
                throw new Exception("Number of attacks was not entered. Please enter a number of attacks.");
            }

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(attacks))
            {
                throw new Exception("Weapon skill has to be a numerical value. Please enter a numerical value for weapon skill");
            }


        }
        public void APCheck(string ap) {

            if (string.IsNullOrEmpty(ap))
            {
                throw new Exception("No ap value was entered. Please enter an ap value.");
            }

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(ap))
            {
                throw new Exception("AP has to be a numerical value. Please enter a numerical value for ap.");
            }

        }
        public void DamageCheck(string damage) {

            if (string.IsNullOrEmpty(damage))
            {
                throw new Exception("Damage dealt was not entered. Please enter a damage value.");
            }

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(damage))
            {
                throw new Exception("Damage dealt has to be a numerical value. Please enter a damage value.");
            }


        }
        public void DummyCheck(string dummy) {

            if (string.IsNullOrEmpty(dummy))
            {
                throw new Exception("No enemy dummy entered. Please choose a dummy name.");
            }

        }

    }
}
