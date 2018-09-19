using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumsKaratavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas uzd = new Karatavas();
            uzd.Menu();

            Console.ReadLine();
        }
    }
}
