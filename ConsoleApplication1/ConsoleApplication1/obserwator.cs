using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface Obserwowany
    {
        void dodajObserwatora(Para o);
        void usunObserwatora(Obserwator o);
        void powiadamiajObserwatorow(miejsce m);

    }
    interface Obserwator
    {
       void  aktualizuj(miejsce m);
    }

}
