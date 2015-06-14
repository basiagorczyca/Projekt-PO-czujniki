using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Wyswietlacz : Obserwator
    {
        public miejsce mojeMiejsce;
        public List<Pomiar> pomiar2;
  
        public Wyswietlacz(miejsce mojeMiejsce)
        {
            this.mojeMiejsce = mojeMiejsce;
            pomiar2 = new List<Pomiar>();
        }
        public void aktualizuj(miejsce m)
        {   if (m == mojeMiejsce)
            {
                Console.WriteLine("Pomieszczenie: " + mojeMiejsce);
            }
        }

        public void dodajPomiar(Pomiar p)
        {
            pomiar2.Add(p);
            
        }
        public void wyswietl()
        {
            foreach (Pomiar pom in pomiar2)
            {
                Console.WriteLine(pom.data.ToString() +" " + pom.wartosc +" "+ pom.jednostka);
            }
            pomiar2.Clear();
        }
    }
}
