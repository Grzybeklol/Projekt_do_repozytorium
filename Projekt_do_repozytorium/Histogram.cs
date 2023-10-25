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
        public int Max { get => max; }
        public Histogram(string tekst)
        {
            tekst = PrzygotujTekst(tekst);
            UtworzSlownik(tekst);
            ZnajdzNajwiekszeWystapienie();
        }
        private void ZnajdzNajwiekszeWystapienie()
        {
            foreach (int ilosc in _slownik.Values)
            {
                if (ilosc > max)
                    max = ilosc;
            }
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
        public void RysujHistogram(int wysokoscWykresu = 30)
        {

            float skala = (float)wysokoscWykresu / Max;
            for (int linia = 0; linia < wysokoscWykresu; linia++)
            {
                foreach (char t in Elementy.Keys.OrderBy(s => s))
                {
                    if (wysokoscWykresu - linia < skala * Elementy[t])
                        Console.Write(centeredString("█", 7));
                    else
                        Console.Write("       ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (char t in Elementy.Keys.OrderBy(s => s))
            {
                //Console.WriteLine($"{t}:{h.Elementy[t]}");
                Console.Write($"   {t}   ");

            }
            Console.WriteLine();
            foreach (char t in Elementy.Keys.OrderBy(s => s))
            {
                Console.Write(centeredString(Elementy[t].ToString(), 7));

            }
        }
        static string centeredString(string s, int width)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
    }
}
