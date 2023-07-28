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

            if(string.IsNullOrEmpty(weaponName))
            {
                throw new Exception("No name entered. Please enter a weapon name.");
            }

            if (string.IsNullOrEmpty(strength))
            {
                throw new Exception("No value entered for strength. Please enter a value.");
            }
        }
        public bool WeaponNameCheck(string weaponName) {
        
            if(weaponName == null || weaponName == "")
            {
                MessageBox.Show("Please enter the name of the weapon used.", "No Weapon Name",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool StrengthCheck(int strength) {

            Regex regex = new Regex("^[0-9]+$");

            if(regex.Equals(strength))
            {
                return true;
            }

            MessageBox.Show("Please enter a number for the strength value.", "Incorrect Strength Amount",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        public bool WeaponSkillCheck(int weaponSkill) {

            Regex regex = new Regex("^[0-9]+$");

            if (regex.Equals(weaponSkill))
            {
                return true;
            }

            MessageBox.Show("Please enter a number for the weapon skill value.", "Incorrect Weapon Skill Amount",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        public bool AttacksCheck(int attacks) {

            Regex regex = new Regex("^[0-9]+$");

            if (regex.Equals(attacks))
            {
                return true;
            }

            MessageBox.Show("Please enter a number for the attacks value.", "Incorrect Attack Amount",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        public bool APCheck(int ap) {

            Regex regex = new Regex("^[0-9]+$");

            if (regex.Equals(ap))
            {
                return true;
            }

            MessageBox.Show("Please enter a number for the ap value.", "Incorrect AP Amount",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        public bool DamageCheck(int damage) {
            Regex regex = new Regex("^[0-9]+$");

            if (regex.Equals(damage))
            {
                return true;
            }

            MessageBox.Show("Please enter a number for the damage value.", "Incorrect Damage Amount",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        public bool DummyCheck(string dummy) {

            return true;
        }

    }
}
