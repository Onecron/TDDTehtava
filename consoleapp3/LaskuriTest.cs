using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTehtävä
{
    [TestFixture]
    public class LaskuriTest
    {
        Laskuri laskuri;

        [SetUp]
        public void Alustus()
        {
            laskuri = new Laskuri();
        }

        // Tarvitaan testata kaikki mahdolliset yhdistelmät joita voi syntyä pelin aikana.
        // Jokaista mahdollista tulosta ei kannata koodata erikseen koska mahdollisuuksia on todella monta.
        // Pitää keksiä jonkinlainen ratkaisu.
        // Yksi mahdollinen ratkaisu olisi jonkinlainen ratkaisu joka laskee jokaisen heiton erikseen


        // Toimiva testi jos ei yhtään pisteitä
        [Test]
        public void EiPisteitä()
        {
            Laskuri laskuri = new Laskuri();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
                laskuri.Tyhjäruutu(0, 0);
            Assert.AreEqual(0, laskuri.Tulos());
        }
        //testi jossa kaikki heidot ovat kaatoja
        [Test]
        public void KaikkiKaatoja()
        {
            Laskuri game = new Laskuri();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
                laskuri.Tyhjäruutu(3, 3);
            Assert.AreEqual(60, laskuri.Tulos());
        }
    }
}
