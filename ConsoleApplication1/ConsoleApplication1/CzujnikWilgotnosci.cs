using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CzujnikWilgotnosci : Czujnik
    {


        public override void aktualizuj(miejsce m)
        {
             if (m == mojeMiejsce)
            {
            base.WykonajPomiar("%");
            }
        }

        public CzujnikWilgotnosci(miejsce mojeMiejsce)
        {
            this.mojeMiejsce = mojeMiejsce;
            min = 30;
            max = 70;
        }
       

    }
}
