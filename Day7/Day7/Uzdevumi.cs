using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevumi
    {
        public void Izvelne()
        {
            Viendimensija();
        }

        private void Viendimensija()
        {
            int masivaGarums = 0;
            while (masivaGarums <= 0 || masivaGarums > 9)
            {
                masivaGarums = Papildus();
                if (masivaGarums < 1 || masivaGarums > 9)
                {
                    Console.WriteLine("Nepareiza ievade");
                }
            }

            String[] Masivs = new String[masivaGarums];
            int i = 0;
            Masivs[i] = "";

            while (Masivs.Length > 6)
            {
                for (i = 0; i < masivaGarums; i++)
                {
                    Console.WriteLine("Ievadiet masiva vertibu");
                    Masivs[i] = Console.ReadLine();
                    
                    if (Masivs.Length > 6)
                    {
                        Console.WriteLine("!Error!");
                    }
                }
            }

            for (i = 0; i < Masivs.Length; i++)
                {
                    Console.WriteLine(Masivs[i]);
                }
            
        }
    
        public int Papildus()
        {
            int masivaGarums2 = 0;
            try
            {
                Console.WriteLine("Ievadiet masiva garumu");
                String ievade = Console.ReadLine();
                masivaGarums2 = Convert.ToInt16(ievade);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nepareiza ievade, masivam pieskirts garums 5");
                Console.WriteLine(ex.Message);

            }
            
            return masivaGarums2;
        }

        private void Divdimensija()
        {
        }  
    }
}