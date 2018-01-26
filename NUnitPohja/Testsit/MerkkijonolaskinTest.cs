using Harj;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testsit
{
    [TestFixture]
    public class MerkkijonolaskinTest
    {
        [Test]  //tyhjä palauttaa nollan.
        public void TyhjaMerkkijonoPalauttaNollan()
        {
            Merkkijonolaskin laskin = new Merkkijonolaskin();

            Assert.That(laskin.Summa(""), Is.EqualTo(0));
        }
    }
}