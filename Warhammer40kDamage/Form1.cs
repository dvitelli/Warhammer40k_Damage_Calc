using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Warhammer40kDamage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void runCalcButton_Click(object sender, EventArgs e)
        {
                   
            WeaponObject weapon = new WeaponObject(weaponNameTextBox.Text, weaponTypeComboBox.Text, int.Parse(strengthTextBox.Text), int.Parse(weaponSkillTextBox.Text),
                                                   int.Parse(attacksTextBox.Text), int.Parse(apTextbox.Text), int.Parse(damageTextBox.Text));

            DummySheetSetup dummySheets = new DummySheetSetup();
            weapon.testCalc(dummySheets.Setup(enemySheetListBox.Text));
   

        }

        
    }
}
