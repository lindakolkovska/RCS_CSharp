using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            PirmaisPiemers PirmaisP = new PirmaisPiemers();
            String izvele = "";

            while (izvele != "0")
            {
                Console.WriteLine("Nospiediet 1, lai...");
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        PirmaisP.DarbibArMasivu();
                        break;
                    case "2":
                        PirmaisP.Stripas();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            } Console.ReadLine();
        }
    }
}
