using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Para 
    {
        public List<Obserwator> czujniki;
        public Wyswietlacz wyswietlacz;
        public Para(miejsce mojeMiejsce)
        {
            czujniki = new List<Obserwator>();
            czujniki.Add(new CzujnikTemp(mojeMiejsce));
            czujniki.Add(new CzujnikWilgotnosci(mojeMiejsce));
            wyswietlacz = new Wyswietlacz(mojeMiejsce);
        }

        public void polacz(miejsce mojeMiejsce)
        { if (mojeMiejsce != wyswietlacz.mojeMiejsce)
                return;
            foreach (Obserwator x in czujniki)
            {
                wyswietlacz.dodajPomiar(((Czujnik)x).pomiary.Last());
            }
            wyswietlacz.wyswietl();
        }
    }
}
