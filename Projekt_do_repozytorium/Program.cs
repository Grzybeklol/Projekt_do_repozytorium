
﻿
using Projekt_do_repozytorium;
using System;

string tekst=Menu.MenuHistogram();
Histogram h = new Histogram(tekst);
Console.Clear();
h.RysujHistogram();

Console.ReadLine();