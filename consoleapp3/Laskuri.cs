using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTehtävä
    {
    public class Laskuri
    {
        ArrayList Heittoja;

        public Laskuri()
        {
            Heittoja = new ArrayList();
        }

        public void Tyhjäruutu(int EnsimmäinenHeitto, int ToinenHeitto)
        {
            Heittoja.Add(EnsimmäinenHeitto);
            Heittoja.Add(ToinenHeitto);
        }

        public int Tulos()
        {
            int total = 0;
            foreach (int pins in Heittoja)
                total += pins;
            return total;
        }
    }
}
