using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TDDTest
{
    public class Persoon
    {
        private static readonly Regex regex = new Regex("\\w+");
        private readonly List<string> voornamen;
        public Persoon(List<string> voornamen)
        {
            if (voornamen == null)
                throw new ArgumentNullException();
            if (voornamen.Count == 0)
                throw new ArgumentException();
            foreach (var voornaam in voornamen)
            {
                int i = 0;
                if (!regex.IsMatch(voornaam))
                    throw new ArgumentException();
                foreach (var testVoornaam in voornamen)
                {
                    if (voornaam == testVoornaam||voornaam.ToUpper() == testVoornaam.ToUpper())
                    {
                        i++;
                        if (i == 2)
                            throw new ArgumentException();
                    }
                }
            }
            this.voornamen = voornamen;
        }

        public override string ToString()
        {
            string tekst = "";
            foreach (var voornaam in voornamen)
                tekst += voornaam + " ";
            return tekst;
        }
    }
}
