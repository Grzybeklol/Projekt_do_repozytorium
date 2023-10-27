
using Projekt_do_repozytorium;
using System;

List<char> zakresliter = new List<char> { 'A', 'H', 'F', 'D', 'X' };
string tekst=Menu.MenuHistogram();
HiStOgRaM h = new HiStOgRaM(tekst, zakresliter);
Console.Clear();
h.RySuJhIsToGrAm();

Console.ReadLine();