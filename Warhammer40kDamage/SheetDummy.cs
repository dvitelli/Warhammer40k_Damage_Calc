using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40kDamage
{
    class SheetDummy
    {
        private string name;
        private int toughness;
        private int save;
        private int invulnSave;
        private int feelNoPain;
        private int hp;

        public SheetDummy()
        {
            name = "Dummy";
            toughness = 0;
            save = 0;
            invulnSave = 0;
            feelNoPain = 0;
            hp = 1;
        }

        public SheetDummy(string name, int toughness, int save, int invulnSave, int feelNoPain, int hp)
        {
            this.name = name;
            this.toughness = toughness;
            this.save = save;
            this.invulnSave = invulnSave;
            this.feelNoPain = feelNoPain;
            this.hp = hp;
        }

        public string Name { get { return name; } }
        public int Toughness { get { return toughness; } }
        public int Save { get { return save; } }
        public int InvulnSave { get { return invulnSave; } }
        public int FeelNoPain { get { return feelNoPain; } }
        public int HP { get { return hp; } }
    }
}
