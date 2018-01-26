using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPohja
{
    [TestFixture]
    class MyTests
    {
        [TestCase]
        public void Add()
        {
            myMath math = new myMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }

        [TestCase]
        public void Sub()
        {
            myMath math = new myMath();
            Assert.AreEqual(10, math.Sub(20, 10));
        }
    }
}
