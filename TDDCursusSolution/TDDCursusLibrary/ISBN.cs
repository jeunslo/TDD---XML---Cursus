using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        private readonly long ISBNNummer;
        public ISBN(long nummer)
        {
            if (nummer < 1000000000000L || nummer > 9999999999999L)
                throw new ArgumentOutOfRangeException();
            decimal evengetal = 0;
            List<char> sISBN = nummer.ToString().ToList();
            for (var i = 1; i < 12; i += 2)
            {
                evengetal += sISBN[i] - 48;

            }
            decimal onevengetal = 0;
            for (var i = 0; i < 12; i += 2)
            {
                onevengetal += sISBN[i] - 48;
            }
            evengetal *= 3;
            decimal som = evengetal + onevengetal;
            decimal tiental = (Math.Floor(som / 10 + 1)) * 10;
            decimal verschil = tiental - som;
            if (verschil != (sISBN[12] - 48) && !(verschil == 10 && (sISBN[12] - 48) == 0))
                throw new ArgumentException();
            this.ISBNNummer = nummer;
        }
        public override string ToString()
        {
            return ISBNNummer.ToString();
        }
    }
}
