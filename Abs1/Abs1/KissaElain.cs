using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
    class KissaElain : JokuElain
    {
        public KissaElain(string laji) : base(laji)
        {
        }

        public override string GetLaji()
        {
            return "KissaElain";
        }
    }
}
