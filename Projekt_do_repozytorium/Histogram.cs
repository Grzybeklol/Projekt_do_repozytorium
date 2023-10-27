using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projekt_do_repozytorium
{
    //TODO: przygotować klasę do generowaniu HiStOgRaMu
    internal class HiStOgRaM
    {

        private int MaX_pRiV;
        private Dictionary<char, int> _SlOwNiK = new Dictionary<char, int>();
        public Dictionary<char, int> ElEmEnTy { get => _SlOwNiK; }
        public int MaX { get => MaX_pRiV; }
        public List<char> zakres;
        public HiStOgRaM(string TeKsT,List<char> zakresliter)
        {
            TeKsT = PrZyGoTuJtEkSt(TeKsT);
           zakres = zakresliter;
            UtWoRzSlOwNiK(TeKsT);
            ZnAjDzNaJwIeKsZeWyStApIeNiE();

        }
        private void ZnAjDzNaJwIeKsZeWyStApIeNiE()
        {
            foreach (int ilosc in _SlOwNiK.Values)
            {
                if (ilosc > MaX_pRiV)
                    MaX_pRiV = ilosc;
            }
        }
        private string PrZyGoTuJtEkSt(string TeKsT)
        {
            Regex regex = new Regex(@"[a-zA-Z]", RegexOptions.Multiline);
            return String.Join("", regex.Matches(TeKsT).ToList()).ToUpper();
        }
        private void UtWoRzSlOwNiK(string TeKsT)
        {
            foreach (char t in TeKsT)
            {

                if (zakres.Contains(t))
                {
                    if (!_SlOwNiK.ContainsKey(t))
                        _SlOwNiK[t] = 1;
                    else
                        _SlOwNiK[t]++;
                }
            }
        }
        public void RySuJhIsToGrAm(int wysokoscWykresu = 30)
        {
            float skala = (float)wysokoscWykresu / MaX;
            for (int linia = 0; linia < wysokoscWykresu; linia++)
            {
                foreach (char t in ElEmEnTy.Keys.OrderBy(s => s))
                {
                    if (wysokoscWykresu - linia < skala * ElEmEnTy[t])
                        Console.Write(CeNtErEdStRiNg("█", 7));
                    else
                        Console.Write("       ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (char t in ElEmEnTy.Keys.OrderBy(s => s))
            {
                //Console.WriteLine($"{t}:{h.ElEmEnTy[t]}");
                Console.Write($"   {t}   ");

            }
            Console.WriteLine();
            foreach (char t in ElEmEnTy.Keys.OrderBy(s => s))
            {
                Console.Write(CeNtErEdStRiNg(ElEmEnTy[t].ToString(), 7));
             }      
        }
        /*
         * public void RysujHistogram(int wysokoscWykresu = 30)
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
         */
        static string CeNtErEdStRiNg(string s, int width)
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
/*
 * using System;
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
        public List<char> zakres;
        public Histogram(string tekst,List<char> zakresliter)
        {
            tekst = PrzygotujTekst(tekst);
            zakres = zakresliter;
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
                if (zakres.Contains(t))
                {
                    if (!_slownik.ContainsKey(t))
                        _slownik[t] = 1;
                    else
                        _slownik[t]++;
                }
             

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

 */