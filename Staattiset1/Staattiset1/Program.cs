using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staattiset1
{
    class Program
    {
        static void Main(string[] args)
        {
            ApuToiminnat apu = new ApuToiminnat();
            apu.nimi = "apu1";

            ApuToiminnat apu2 = new ApuToiminnat();
            apu2.nimi = "apu2";

            Console.WriteLine(apu.GetNimi());
            Console.WriteLine(apu2.GetNimi());
            Console.WriteLine(ApuToiminnat.GetLuokanNimi());
            
        }
    }
}
