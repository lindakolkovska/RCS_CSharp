using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Piemers2();
            //int skaitlis = Piemers3();
            //Console.WriteLine(skaitlis);
            //Console.ReadLine();
            //Piemers4();

            //int reizes = SkaitlaIevade();
            //Zvaigzne(reizes);


            Console.ReadLine();

        }

        /*static void Piemers()
        {
            // for, while, do..while, foreach

            for (int i = 0; i < 5; i++) // uzraksta Hello World 5 reizes
            {
                Console.WriteLine("Hello World!");
            }


            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            /*int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            j = 0;
            do           // do while - izdara vismaz 1.reizi
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);*/


            /*string x = "*";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(x);
                x += "*";
            };

        }
        static void Piemers2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static int Piemers3()
        {
            int rezultats = 6 + 8;
            return rezultats;
        }

        static void Piemers4()
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;
            Piemers();   // piemet klāt rezultātam visu, kas iepriekš definēts f-jā Piemers().

            Console.WriteLine(summa);
        }

        static int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli");
            String ieraksts = Console.ReadLine();
            int ierakstsskaitli1 = Convert.ToInt16(ieraksts);

            return ierakstsskaitli1;    // ja izmanto static int - var iekļaut return, kas nozīmē, ka var citā f-jā izmantot šo f-ju
        }

        static void Zvaigzne(int robeza)
        {
           string x = "*";
           for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(x);
                x += '*';
            }
        }*/

        
    }
}

