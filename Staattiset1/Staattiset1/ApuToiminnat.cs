using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staattiset1
{
    class ApuToiminnat
    {
        public string nimi = "Tyhjä";
        public static string LuokanNimi = "ApuToiminnat";


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
            return LuokanNimi;
        }
    }
}
