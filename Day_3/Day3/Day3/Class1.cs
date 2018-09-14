using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Matematika
    {
        public void Saskaitit()
        {
            Console.WriteLine("Ievadiet skaitli");
            string ievaditais = Console.ReadLine();
            int jaunaisskaitlis = Convert.ToInt16(ievaditais);

            Console.WriteLine("Ievadiet skaitli2");
            string ievaditais2 = Console.ReadLine();
            int jaunaisskaitlis2 = Convert.ToInt16(ievaditais2);

            int sum = jaunaisskaitlis + jaunaisskaitlis2;
            Console.WriteLine(sum);
        }
        public void Atnemsana()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            int starp = a - b;
            Console.WriteLine(starp);
        }

        public void Apvienota()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            Console.WriteLine("Ievadiet 1, lai saskaitītu vai 2, lai atņemtu");
            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Console.WriteLine(a + b);

            }
            else if (izvele == "2")
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Ievade nav pareiza");
            }
        }

        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet skaitli");
            string ievaditais = Console.ReadLine();
            int jaunaisskaitlis = Convert.ToInt16(ievaditais);

            return jaunaisskaitlis;
        }


        public void Formula()
        {
            String teikums = "";
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet vardu");
                String z = Console.ReadLine();
                teikums = teikums + " " + z;
            }
            Console.WriteLine(teikums);
        }

        public void Kapinasana()
        {
            /*Console.WriteLine("Ieraksti skaitli");
            String a = Console.ReadLine();
            int rezultats1 = Convert.ToInt16(a);*/

            int skaitlis = Parveidosana();

            Console.WriteLine("Ieraksti kapinataju");
            String b = Console.ReadLine();
            int robeza = Convert.ToInt16(b);

            int rezultats = 1;

            for (int i = 0; i < robeza; i++)
            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }
    }
}
