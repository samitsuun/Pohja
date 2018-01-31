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
            List<StringBuilder> sblista = new List<StringBuilder>();
            sblista.Add(new StringBuilder("abc"));
            sblista.Add(new StringBuilder("def"));

            StringBuilder sb = sblista[1];
            Console.WriteLine(sb.Insert(0,"2"));
            Console.WriteLine((sblista[0].Insert(0, "1")));



            //Dictionary tyyppinen luettelo:
            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("sana", "ord");
            sanakirja.Add("kirja", "bok");
            sanakirja.Add("koira", "hund");
            sanakirja.Add("kyllä", "ja");

            Console.WriteLine(sanakirja["kyllä"]);




            string ohje = "0.Lopetus\n.Toiminto 1\n";

            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0"))   // ! tarkoittaa NOT
            {
                switch (komento)
                {
                    case "1":
                        Console.WriteLine("Anna Hakusana: ");
                        string sana = Console.ReadLine();
                        Console.WriteLine(sanakirja[sana.ToLower().Trim()]);
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
