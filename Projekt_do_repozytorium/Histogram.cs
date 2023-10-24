using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projekt_do_repozytorium
{
    //TODO: przygotować klasę do generowaniu histogramu
    internal class Histogram
    {
        private int max;
        private Dictionary<char, int> _slownik = new Dictionary<char, int>();
        public Dictionary<char, int> Elementy { get => _slownik; }
        public Histogram(string tekst)
        {
            tekst = PrzygotujTekst(tekst);
            UtworzSlownik(tekst);
        }
        private string PrzygotujTekst(string tekst)
        {
            Regex regex = new Regex(@"[a-zA-Z]", RegexOptions.Multiline);


            return String.Join("", regex.Matches(tekst).ToList()).ToUpper();
        }
        private void UtworzSlownik(string tekst)
        {
            foreach (char t in tekst)
            {
                if (!_slownik.ContainsKey(t))
                    _slownik[t] = 1;
                else
                    _slownik[t]++;

            }
        }
    }
}
