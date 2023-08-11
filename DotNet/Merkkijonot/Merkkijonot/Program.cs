/*
 - Intel Core i9-9900 CPU @ 3.10GHz
 - 500k kertaa: 38,5 sekuntia
 - 600k kertaa: 58 sekuntia
*/

using System.Text;

DateTime alku = DateTime.Now;

StringBuilder rakentaja = new();
for (int i = 0; i < 600_000; i++)
{
    rakentaja.Append("A");
}
string s = rakentaja.ToString();
Console.WriteLine(s.Length);

/*
int tulos = 0;
for (int i = 0; i < 500_000; i++)
{
    // tulos = tulos + 1;
    // tulos += 1;
    tulos++;
}
Console.WriteLine(tulos);
*/

DateTime loppu = DateTime.Now;

TimeSpan kesto = loppu - alku;
Console.WriteLine("Silmukan kesto: " + kesto.TotalSeconds);
