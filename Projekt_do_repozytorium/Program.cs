
﻿
using Projekt_do_repozytorium;
using System;

string tekst=Menu.MenuHistogram();
HiStOgRaM h = new HiStOgRaM(tekst);
Console.Clear();
h.h.RySuJhIsToGrAm();

Console.ReadLine();