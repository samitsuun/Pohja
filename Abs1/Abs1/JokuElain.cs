using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
   abstract class JokuElain
    {
        string laji;
        public JokuElain(string laji)
        {
            this.laji = laji;
        }

        public abstract string GetLaji();
    }
}
