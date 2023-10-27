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
        public HiStOgRaM(string TeKsT)
        {
            TeKsT = PrZyGoTuJtEkSt(TeKsT);
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
                if (!_SlOwNiK.ContainsKey(t))
                    _SlOwNiK[t] = 1;
                else
                    _SlOwNiK[t]++;

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
