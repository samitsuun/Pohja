using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staattiset1
{
     class ApuToiminnat
    {
        static int ctr = 0;
        public string nimi = "Tyhjä";
        public static string LuokanNimi = "ApuToiminnat";

        public ApuToiminnat()
        {
            ctr++;
        }

        public string GetNimi()
        {
            return nimi;
        }

        public static int LaskePituus(string s)
        {
            return s.Length;
        }

        public static string GetLuokanNimi()
        {
            return LuokanNimi + "-Luokasta on tehty " + ctr + " oliota.";
        }
    }
}
