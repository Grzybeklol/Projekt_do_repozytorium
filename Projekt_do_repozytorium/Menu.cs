using Projekt_do_repozytorium;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;

static class Menu
{
    static string[] opcje = { "Z klawiatury", "Z url" };
    static int WybieranaOpcja = 0;
    public static string MenuHistogram()
    {
        Console.Title = "Histogram";
        string Pomocnicza;
        while (true)
        {
            WypiszMenu();
            WybieranieOpcji();
            Pomocnicza=WybranaOpcja();
            break;
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        return Pomocnicza;
    }
    public static void WypiszMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("Wybierz metode podania tekstu: ");
        for (int x = 0; x < opcje.Length; x++)
        {
            if (WybieranaOpcja == x)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(opcje[x]);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine(opcje[x]);
            }
        }
    }
    public static void WybieranieOpcji()
    {
        do
        {
            ConsoleKeyInfo WcisnietyKlawisz = Console.ReadKey();
            if (WcisnietyKlawisz.Key == ConsoleKey.UpArrow)
            {
                if (WybieranaOpcja == 0)
                {
                    WybieranaOpcja++;
                    WypiszMenu();
                }
                else
                {
                    WybieranaOpcja--;
                    WypiszMenu();
                }
            }
            else if (WcisnietyKlawisz.Key == ConsoleKey.DownArrow)
            {
                if (WybieranaOpcja == 1)
                {
                    WybieranaOpcja--;
                    WypiszMenu();
                }
                else
                {
                    WybieranaOpcja++;
                    WypiszMenu();
                }
            }
            else if (WcisnietyKlawisz.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        while (true);
    }
    public static string WybranaOpcja()
    {
        switch (WybieranaOpcja)
        {
            case (0):
                Console.Clear();
                Console.WriteLine("Podaj tekst: ");
                return Console.ReadLine();
            case (1):
                Console.Clear();
                Console.WriteLine("Podaj url: ");
                string Url = Console.ReadLine();
                Task<string> test = URL.PobieranieZURL(Url);
                return test.Result;
        }
        return "";
    }
}
    public class URL
    {
        public static async Task<string> PobieranieZURL(string Url)
        {
            using (HttpClient client = new HttpClient())
            {
                string s = await client.GetStringAsync(Url);
                return s;
            }
        }
    }
