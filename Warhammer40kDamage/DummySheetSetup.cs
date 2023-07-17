using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40kDamage
{
    class DummySheetSetup
    {
        public SheetDummy Setup(string dummySelection)
        {

            SheetDummy dummy = new SheetDummy();
            List<SheetDummy> dummyList = SheetSetup();

            foreach (SheetDummy s in dummyList)
            {
                if (s.Name == dummySelection)
                {
                    dummy = s;
                }
            }

            return dummy;

        }

        private static List<SheetDummy> SheetSetup()
        {
            List<SheetDummy> dummyList = new List<SheetDummy>();
            SheetDummy spaceMarine = new SheetDummy("Space Marine", 4, 3, 0, 0, 2);
            SheetDummy aberrants = new SheetDummy("Aberrants", 6, 5, 0, 4, 3);

            dummyList.Add(spaceMarine);
            dummyList.Add(aberrants);

            return dummyList;
        }
    }
}
