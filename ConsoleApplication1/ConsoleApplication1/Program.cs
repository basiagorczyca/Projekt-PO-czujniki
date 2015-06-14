using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            Centrala centralka = new Centrala();
            
            centralka.dodajObserwatora(new Para(miejsce.garaz));
            centralka.dodajObserwatora(new Para(miejsce.pokojDzienny));
            centralka.dodajObserwatora(new Para(miejsce.kuchnia));

            int x = 0;
            while (true)
            {
                Console.WriteLine("Wybierz miejsce do pomiaru: 1. Garaż, 2. Pokój dzienny, 3. Kuchnia");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                
                    Console.WriteLine(e.Message);
                }

                switch (x)
                {
                    case 1:
                        
                        centralka.powiadamiajObserwatorow(miejsce.garaz); 
                        break;

                    case 2:

                        centralka.powiadamiajObserwatorow(miejsce.pokojDzienny);
                        break;
                    case 3:

                        centralka.powiadamiajObserwatorow(miejsce.kuchnia);
                        
                        break;
                    default:
                        Console.WriteLine("Zły wybór");
                        break;
                }
                Console.ReadLine();
                x = 0;
            
            }
            
        }
    }
}
