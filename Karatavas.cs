using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumsKaratavas
{
    class Karatavas
    {
        public void Menu()
        {
            Uzdevums();
        }

        private void Uzdevums()
        {
            char[] masivs = new char[13] { 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'e', 's', 'a', 'n', 'a' };
            char[] masivs2 = new char[13] { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_',};
            char burts = ' ';
            

            Console.WriteLine("Ievadiet burtu");
            String ievade = Console.ReadLine();
            burts = Convert.ToChar(ievade);

            for (int i = 0; i < masivs.Length; i++)
            {
                while (burts == masivs[i])
                {
                    Console.WriteLine("Ievadiet burtu");
                    ievade = Console.ReadLine();
                    burts = Convert.ToChar(ievade);


                    if (burts == masivs[i])
                    {
                        for (i = 0; i < masivs.Length; i++)

                        {
                            int pozicija = Array.IndexOf(masivs, burts);
                            masivs2[pozicija] = burts;
                            Console.Write(masivs2);
                        }
                    }
                    else if (burts != masivs[i])
                    {
                        Console.WriteLine("Nepareiza ievade");
                    }
                }
            

            }
            
        }
    }
}
