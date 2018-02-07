using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTehtävä
{
    [TestFixture]
    public class Keilauksen_pistelaskuri_test
    {
        Laskuri laskuri;

        [SetUp]
        public void Alustus()
        {
            laskuri = new Laskuri();
        }
        [Test]
        public void EiKaatoja()
        {
            Laskuri laskuri = new Laskuri();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
                laskuri.Tyhjäruutu(0, 0);
            Assert.AreEqual(0, laskuri.Score());
        }




    }
}
