using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Piemeri
    {
         public void Interfeiss()
         {
             int mainigais = 5;
             int[] pirmaisMasivs = new int[mainigais];

             pirmaisMasivs[0] = 1;
             pirmaisMasivs[1] = 7;
             pirmaisMasivs[2] = 7;
             pirmaisMasivs[3] = 9;
             pirmaisMasivs[4] = 3;

             for (int i = 0; i < pirmaisMasivs.Length; i++)
             {
                 Console.WriteLine(pirmaisMasivs[i]);
             }
         }

        public int Ievadisana() {
            Console.WriteLine("Ievadiet masiva garumu");
            String ievaditaVertiba = Console.ReadLine();
            int MasivaVertiba = Convert.ToInt16(ievaditaVertiba);
            return MasivaVertiba;
        }

        public int Ievadisana2()
        {
            Console.WriteLine("Ievadiet masiva vertibu");
            String ievaditaVertiba = Console.ReadLine();
            int MasivaVertiba = Convert.ToInt16(ievaditaVertiba);
            return MasivaVertiba;
        }

        public void Interfeiss2()
        {
            int jauns = Ievadisana();
            int[] uzdevumaMasivs = new int[jauns];

            for (int i = 0; i < uzdevumaMasivs.Length; i++)
            {
                uzdevumaMasivs[i] = Ievadisana2();
                Console.WriteLine("Masiva skaitlis ir" + uzdevumaMasivs[0]);
            }

        }

        public void Interfeiss3()
        {
            //int mainigais = 5;
            String[] pirmaisMasivs = new String[4] { "*", "**", "***", "****" }; // te [] ir rakstīts 4, bet ja raktītu mainīgais, būtu 5;
            /*pirmaisMasivs[0] = "*";
            pirmaisMasivs[1] = "**";
            pirmaisMasivs[2] = "***";
            pirmaisMasivs[3] = "****";*/

        for (int i = 0; i < pirmaisMasivs.Length; i++)
        {
            Console.WriteLine(pirmaisMasivs[i]);
        }

        for (int i =0; i < 4; i++)
        {
            Console.WriteLine(pirmaisMasivs[i]);
            pirmaisMasivs[0] = pirmaisMasivs[0] + pirmaisMasivs[0];
        }

    }

        public void Interfeiss4()
        {
            String[] pirmaisMasivs = new string[4] {"*", "*", "*", "*"};

            for (int i = 0; i < pirmaisMasivs.Length; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(pirmaisMasivs[j]);
                }
                Console.WriteLine();
            }
        }

        public void DiviD()
        {
            int[,] OtraisP= new int[2,2];

            OtraisP[0,0] = 5;
            OtraisP[0,1] = 1;
            OtraisP[1,0] = 6;
            OtraisP[1,1] = 9;

            for(int i=0; i < 2; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.Write(OtraisP[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
