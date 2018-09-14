using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Matematikaa
    {
        private void Saskaitit()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a + b;
            Console.WriteLine(rezultats);
        }

        private void Atnemsana()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a - b;
            Console.WriteLine(rezultats);
        }


        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String virkne = Console.ReadLine();
            int result = Convert.ToInt16(virkne);
            return result;
        }
        //5 reizes prasa ievadit kadu vardu un tad beigas mes to visu izvadam
        //MartinsIrLotiLotiForss


        private void Kapinasana()
        {
            int skaitlis = Parveidosana();
            int pakape = Parveidosana();

            int rezultats = 1;
            for (int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }

        public void IzvelkamUzPublicSaskatit()
        {
            Saskaitit();
        }
        public void IzvelkamUzPublicAtnemt()
        {
            Atnemsana();
        }
        public void IzvelkamUzPublicKapinat()
        {
            Kapinasana();
        }

        //cilveks ievada skaitli, cilveks ievada pakapi un tiek rezultats
    }
}
    
