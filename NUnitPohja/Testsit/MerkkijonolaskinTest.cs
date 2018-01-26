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
        Merkkijonolaskin laskin;

        [SetUp]
        public void TestienAlustus()
        {
            laskin = new Merkkijonolaskin();
        }

        [Test]  //tyhjä palauttaa nollan.
        public void TyhjaMerkkijonoPalauttaNollan()
        {
            Assert.That(laskin.Summa(""), Is.EqualTo(0));
        }

        [Test] //1numero = numero.
        public void YksiNumeroPalauttaaAnnetunArvon()
        {
            Assert.That(laskin.Summa("5"), Is.EqualTo(5));
        }

        [Test] //2lukua pilkullla eroteltuna.
        public void KaksiLukuaPilkullaEroteltunaPalauttaaSumman()
        {
            Assert.That(laskin.Summa("1,2"), Is.EqualTo(3));
        }

        [Test] //Useampi luku..
        public void UseampiKuinKaksiLukuaPilkullaEroteltunaPalauttaaSumman()
        {
            Assert.That(laskin.Summa("1,2\n3,4,5,9"), Is.EqualTo(24));
        }

        [Test]//miinusmerkkiset luvut aiheuttaa virheen.
        public void MiinusMerkkisetLuvutEivatToimi()
        {
            Assert.That(laskin.Summa("-2,4,5,6,-7"), Is.EqualTo(000));
        }

        [Test]//Yli 4merkkiä pitkät luvut skipataan.
        public void LiianPitkatLuvutOhitetaan()
        {
            Assert.That(laskin.Summa("4,6,1000,10"), Is.EqualTo(20));
        }
    }
}