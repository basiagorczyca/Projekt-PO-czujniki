using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Centrala : Obserwowany
    {
        public List<Para> para;

        public Centrala()
        { 
            para = new List<Para>();
        }

        public void dodajObserwatora(Para o)
        {
            para.Add(o);
        }
        public void usunObserwatora(Obserwator o)
        {
            foreach (Para p in para)
               p.czujniki.Remove(o);
        }

        public void powiadamiajObserwatorow(miejsce m)
        {
            foreach (Para ob in para)
            {
                foreach(Obserwator obs in ob.czujniki)
                {
                    obs.aktualizuj(m);
                }
                ob.wyswietlacz.aktualizuj(m);
                ob.polacz(m);
            }
        }

     
    }
    }
