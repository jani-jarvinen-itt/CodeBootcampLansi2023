/*
 - Intel Core i9-9900 CPU @ 3.10GHz
 - 500k kertaa: 38,5 sekuntia
 - 600k kertaa: 58 sekuntia
*/

DateTime alku = DateTime.Now;

string s = "";
for (int i = 0; i < 600_000; i++)
{
    s += "A";
}

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
