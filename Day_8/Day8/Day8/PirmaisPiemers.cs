using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class PirmaisPiemers
    {
        public void DarbibArMasivu()
        {
            String[] Masivs = new String[4];
            int i = 0;
            int ievade = 5;

            while (ievade != 0)
            {
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("Ievadiet masiva vertibu vai 0, lai izietu");
                    Masivs[i] = Console.ReadLine();
                    ievade = Convert.ToInt16(Masivs[i]);
                    if (ievade == 0)
                    {
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write(Masivs[j]);
                        }
                    } Console.WriteLine();
                }
            }
        }
        public void Stripas()
        {
            String[] Masivs2 = new string[4] { "-", "-", "-", "-" };

            for (int i =0; i < Masivs2.Length; i++)
            {
                Console.WriteLine(Masivs2[i]);
            }

        }
    }   
}
