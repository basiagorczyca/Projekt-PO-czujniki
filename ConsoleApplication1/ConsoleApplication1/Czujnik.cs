using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum miejsce
    {
        garaz,
        pokojDzienny,
        kuchnia,
    }
    abstract class Czujnik : Obserwator
    { 
        protected miejsce mojeMiejsce;
        public int min, max;
        Random a = new Random();
        public List<Pomiar> pomiary;


        public virtual void WykonajPomiar(string jednostka)
        {
            Pomiar p = new Pomiar();
            p.wartosc = a.Next(min, max);
            p.jednostka = jednostka;
            p.data = DateTime.Now;
            pomiary.Add(p);
        }


        public virtual void OdczytajMiejsce(miejsce m)
        {
            switch (m)
            {
                case miejsce.garaz:
                    min = 0;
                    max = 0;
                    break;

                case miejsce.pokojDzienny:
                    min = 0;
                    max = 0;
                    break;

                case miejsce.kuchnia:
                    min = 0;
                    max = 0;
                    break;

            }
        }

        public abstract void aktualizuj(miejsce m);

        public Czujnik()
        {
            pomiary = new List<Pomiar>();
        }
    }
    
}
