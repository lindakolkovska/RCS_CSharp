using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WritenLine("Hello World!");
             int VeselsSkaitlis = 5;
             double arKomatu = 4.5;
             String simboluVirkne = "definejas sadi";
             char simbols = 'g';
             bool patiessVaiNee = true;

            /*VeselsSkaitlis = 6;
            simboluVirkne = Console.ReadLine();
            Console.WriteLine(VeselsSkaitlis);*/



            //Console.WriteLine(Vards);
            /*Console.ReadLine(Sveiciens);*/


            // Console.WriteLine("Ievadiet skaitli");
            //simboluVirkne = Console.ReadLine();
            //int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);
            //Console.WriteLine(jaunaisSkaitlis);
            //Console.WriteLine("Sveiki, " + simboluVirkne);

            //Console.WriteLine("Ievadiet 1.skaitli");
            //simboluVirkne = Console.ReadLine();
            //int jaunaisSkaitlis1 = Convert.ToInt16(simboluVirkne);
            //Console.WriteLine("Ievadiet 2.skaitli");
            //simboluVirkne = Console.ReadLine();
            //int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne);
            //Console.WriteLine(jaunaisSkaitlis1 + jaunaisSkaitlis2);*/

            /*int test = 4;
            if(test > 5)
            {

            } else
            {

            }*/

            Console.WriteLine("Ievadiet skaitli");
            simboluVirkne = Console.ReadLine();
            int x = Convert.ToInt16(simboluVirkne);
            if (x > 5 && x < 10)
            {
                Console.WriteLine("##");
            } else
            {
                Console.Write("#");
            }

            Console.ReadLine();

        }
    }
}
