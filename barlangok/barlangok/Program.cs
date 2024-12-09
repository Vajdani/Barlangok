using barlangok;

List<Barlang> barlangok = [];
using StreamReader reader = new("../../../src/barlangok.txt");
reader.ReadLine();
while (!reader.EndOfStream)
{
    barlangok.Add(new Barlang(reader.ReadLine()!));
}

Console.WriteLine($"4. feladat: Barlangok száma: {barlangok.Count}");
Console.WriteLine($"5. feladat: A miskolci barlangok átlag mélysége: {barlangok.Where(b => b.Telepules.Contains("Miskolc")).Average(b => b.Melyseg):0.000}m");

Console.Write("6. feladat: Adjon meg egy védettségi szintent: ");
string vedettseg = Console.ReadLine()!;
List<Barlang> vedettBarlangok = barlangok.Where(b => b.Vedettseg == vedettseg).ToList();
if (vedettBarlangok.Count > 0)
{
    Barlang barlang = vedettBarlangok.MaxBy(barlang => barlang.Hossz)!;
    Console.WriteLine($"\tAzon: {barlang.Azon}");
    Console.WriteLine($"\tNév: {barlang.Nev}");
    Console.WriteLine($"\tHossz: {barlang.Hossz}");
    Console.WriteLine($"\tMélység: {barlang.Melyseg}");
    Console.WriteLine($"\tTelepülés: {barlang.Telepules}");
}
else
{
    Console.WriteLine("\tNincs ilyen védettségi szintű barlang az adatok között!");
}

var barlangCsoportok = barlangok.GroupBy(b => b.Vedettseg);
Console.WriteLine("7. feladat: Statisztika");
foreach (var item in barlangCsoportok)
{
    string nev = item.Key + ":";
    Console.WriteLine($"\t{nev + new string('-', 30 - nev.Length), -30}> {item.Count()} db");
}