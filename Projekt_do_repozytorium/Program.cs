
using Projekt_do_repozytorium;

string tekst = "hefi gvewitbhbiwerh bie hrdigfdisebsoavi faousfdbaosdAsafdfsadfadG ADFdsfsdfdgdxgsdsfdsfd#$%#w$twfafs#wtrfwgsd";
Histogram h = new Histogram(tekst);

foreach(var element in h.Elementy)
{ 
    Console.WriteLine($"{element.Key}:{element.Value}");
}

Console.ReadLine();