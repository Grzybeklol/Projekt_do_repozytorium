using Projekt_do_repozytorium;

string tekst = "hefi gvewitbhbiwerh bie hrdigfdisebsoavi faousfdbaosdAsafdfsadfadG ADFdsfsdfdgdxgsdsfdsfd#$%#w$twfafs#wtrfwgsd";
Histogram h = new Histogram(tekst);

List<char> literkidosprawdzenia = new List<char> { 'A', 'H', 'F', 'D', 'X' };

foreach (var element in h.Elementy)
{
    if (literkidosprawdzenia.Contains(element.Key))
    {
        Console.WriteLine($"{element.Key}:{element.Value}");
    }

}

Console.ReadLine();

