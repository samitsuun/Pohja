using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj
{
   public class Merkkijonolaskin
    {
        public int Summa(string luvut)
        {
            if (luvut.Equals(""))
            {
                return 0;
            }

            string[] numerot = luvut.Split(',', '\n');

            int vastaus = 0;
            foreach (var numero in numerot)
            {
                vastaus += int.Parse(numero);
            }
            
            return vastaus;
        }
    }
}
