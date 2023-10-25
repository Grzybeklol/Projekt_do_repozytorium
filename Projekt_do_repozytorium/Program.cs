
﻿
using Projekt_do_repozytorium;

string tekst = "hefi gvewitbhbiwerh bie hrdigfdisebsoavi faousfdbaosdAsafdfsadfadG ADFdsfsdfdgdxgsdsfdsfd#$%#w$twfafs#wtrfwgsd";
List<char> zakresliter = new List<char> { 'A', 'H', 'F', 'D', 'X' };
Histogram h = new Histogram(tekst, zakresliter);



h.RysujHistogram();

Console.ReadLine();

