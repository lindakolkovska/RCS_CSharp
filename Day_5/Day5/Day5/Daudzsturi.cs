using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Daudzsturi
    {
        public void Interfeiss()
        {
            SturuSkaits();
        }

        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet malu skaitu (no 3 līdz 5!) vai iziet");
            String MaluSkaits = Console.ReadLine();
            int result = Convert.ToInt16(MaluSkaits);
           return result;
        }

        private int Parveidosana2()
        {
            Console.WriteLine("Ievadiet malu garumu vai iziet!");
            String MaluGarums = Console.ReadLine();
            int result = Convert.ToInt16(MaluGarums);
            return result;
        }



        private void SturuSkaits()
        {
            String i = "";

            while (i != "Iziet") {
            int a = Parveidosana();
            String c = Convert.ToString(a);
            i = c;

                if (a == 3)
                {
                    Console.WriteLine("Trissturis");
                }
                else if (a == 4)
                {
                    Console.WriteLine("Cetrsturis");
                }
                else if (a == 5)
                {
                    Console.WriteLine("Piecsturis");
                }
                else
                {
                    Console.WriteLine("Nav pareiza ievade");
                }


                if (a == 3 || a == 4 || a == 5)
                {
                    int b = Parveidosana2();
                    if (b > 0) {
                    int Rezultats = a * b;
                    Console.WriteLine("Perimetrs ir " + Rezultats);
                    } else {
                        Console.WriteLine("Skaitlis nevar but negativs");
                    }
                }
            }
        }
    }
}

