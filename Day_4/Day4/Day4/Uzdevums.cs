using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevums
    {
        private int a = 4;
        public int b = 6;

        public void Interfeiss()
        {
            GarumaParbaude();
        }

        private void GarumaParbaude()
        {
            Console.WriteLine("Ieraksti 1 - 12 simbolus ");
            String simboli = Console.ReadLine();

            if (simboli.Length > 1 && simboli.Length < 13)
            {
                Console.WriteLine("Viss ir ok!");
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
            }
        }

        private void Izvelne()
        {
            int c = 11;

            switch(c)    // nav svarīgi, kāda ir sākotnējā vērtība;
            {
                case 0:
                    Console.WriteLine("amm...");
                    break;
                case 1:
                    Console.WriteLine("aaaaammmmm....");
                    break;
                default:
                    Console.WriteLine("nee");
                    break;
            }
        }
        public void IzsaucuIzvelne()
        {
            Izvelne();
        }

        public void Menu()
        {
            String choice = "";

            while (choice != "Iziet")
            {
                Matematikaa Mat = new Matematikaa() ;
                Console.WriteLine("Ieraksti kādu darbību veikt (+,-,^). Ja gribi iziet, raksti Iziet ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        Mat.IzvelkamUzPublicSaskatit();
                        break;
                    case "-":
                        Mat.IzvelkamUzPublicAtnemt();
                        break;
                    case "^":
                        Mat.IzvelkamUzPublicKapinat();
                        break;
                    case "Iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }

        }

        public void Cikli()
        {
            String zvaigzne = "";
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(zvaigzne = zvaigzne + "*");
                i++;
            }
        }

        /*public void IeliktGarumaParbaudi()
        {
            var Parbaudu = new Uzdevums();
            Parbaudu.GarumaParbaude();
        }*/
    }
}
