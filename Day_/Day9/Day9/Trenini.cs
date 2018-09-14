using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Trenini
    {
        public void Menu()
        {
            ZvaigznesVaiReste();

        }

        private void Restite()
        {
            int Daudzums = 0;

            //while (Daudzums != 9)
            {
                try
                {
                    Console.WriteLine("Ievadiet skaitli");
                    String ievade = Console.ReadLine();
                    Daudzums = Convert.ToInt16(ievade);

                    /*if (Daudzums == 9)
                    {
                        break;
                    } else {*/
                        char restite = '#';

                        for (int i = 0; i < Daudzums; i++)
                        {
                            Console.Write(restite);
                        }
                    
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Nepareiza ievade");
                }
                    
            }
        }
        private void Restite3()
        {
            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int Daudzums = Convert.ToInt16(ievade);

            char[] restite = new char[Daudzums];

            for(int i = 0; i < Daudzums; i++)
            {
                restite[i] = '#';
                Console.Write(restite[i]);
            }
            
        }
        private void Restite4()
        {
            String[] reste = new String[5] {"#", "##", "###", "####", "#####"};

            for (int i = reste.Length-1; i >= 0; i--)
            {
                Console.WriteLine(reste[i]);
            }
        }

        private void Faktorials()
        {
            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int Daudzums = Convert.ToInt16(ievade);
            int i = 0;
            int[] masivs = new int[Daudzums];
            int fak = 0;

            for (i = masivs.Length-1; i >= 0; i--)
            {
                masivs[i] = i+1;
                fak = fak + masivs[i];
                
            }
            Console.WriteLine(fak);

            /* alternativa
             Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int Daudzums = Convert.ToInt16(ievade);

            int fak = 0;
            for (int i = 1; i < Daudzums.Length; i++)
            {
            fak = fak + i;
            }
            Console.WriteLine(fak);
             */

        } private void ZvaigznesVaiReste()
        {
            String[] tas = new String[8];
           
            for (int i = 0; i < 8; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine('*');
                } else
                {
                    Console.WriteLine('#');
                }
            }

        }
    }  
}
