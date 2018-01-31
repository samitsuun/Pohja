using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
    class Program
    {
        static void Main(string[] args)
        {
            JokuElain lion = new KissaElain("Jellona");
            Console.WriteLine(lion.GetLaji());
        }
    }
}
