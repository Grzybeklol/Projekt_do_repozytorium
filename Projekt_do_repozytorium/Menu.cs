using Projekt_do_repozytorium;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;

static class Menu
{
    public static string StartMenu()
    {
        Console.Title = "Histogram";
        while (true)
        {
            Console.WriteLine("Wybierz metode podania tekstu: ");
            Console.WriteLine("1 - Z klawiatury");
            Console.WriteLine("2 - Z url");
            ConsoleKeyInfo WybranaOpcja = Console.ReadKey();
            switch(WybranaOpcja.Key) 
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Podaj tekst: ");
                    return Console.ReadLine();
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Podaj url: ");
                    string Url = Console.ReadLine();
                    Task<string> test= URL.PobieranieZURL(Url);
                    return test.Result;
            }
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
}