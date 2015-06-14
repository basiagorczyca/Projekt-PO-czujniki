using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CzujnikTemp : Czujnik
    {

       public CzujnikTemp(miejsce mojeMiejsce)
        {
            this.mojeMiejsce = mojeMiejsce;
            OdczytajMiejsce(mojeMiejsce);
        }


        public override void OdczytajMiejsce(miejsce m)
        {
            switch (m)
            {
                case miejsce.garaz:
                    min = 10;
                    max = 25;
                    break;

                case miejsce.pokojDzienny:
                    min = 15;
                    max = 26;
                    break;

                case miejsce.kuchnia:
                    min = 15;
                    max = 26;
                    break;

            }
        }

        public override void aktualizuj(miejsce m)
        {
              if(m == mojeMiejsce)
           {
             base.WykonajPomiar("°C");
            }
        }
    }
}
