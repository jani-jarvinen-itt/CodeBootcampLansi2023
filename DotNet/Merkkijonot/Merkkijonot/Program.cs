
DateTime alku = DateTime.Now;

string s = "";
for (int i = 0; i < 500_000; i++)
{
    s += "A";
}

DateTime loppu = DateTime.Now;

TimeSpan kesto = loppu - alku;
Console.WriteLine("Silmukan kesto: " + kesto.TotalSeconds);
