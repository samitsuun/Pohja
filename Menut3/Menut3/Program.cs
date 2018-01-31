using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menut3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary tyyppinen luettelo:
            Dictionary<string, string> sanakirja = new Dictionary<string, string>();




            string ohje = "0.Lopetus\n.Toiminto 1\n";

            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0"))   // ! tarkoittaa NOT
            {
                switch (komento)
                {
                    case "1":
                        Console.WriteLine("Valitsit komennon 1");
                        Console.WriteLine(LuoUusi(1));
                        break;
                    default:        // kaikissa muissa tapauksissa
                        break;
                }
                Console.WriteLine(ohje);
                komento = Console.ReadLine();
            }
        }

        static string LuoUusi(int numero)
        {
            return numero + "";
        }

    }
}
