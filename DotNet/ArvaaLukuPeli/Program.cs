Random satunnainen = new();
int oikea = satunnainen.Next(1, 21);
// Console.WriteLine(oikea);

for (int arvauskerta = 0; arvauskerta < 3; arvauskerta++)
{
    Console.WriteLine("Anna arvauksesi välillä 1-20:");
    string syöte = Console.ReadLine();
    int arvaus = int.Parse(syöte);

    if (arvaus < oikea)
    {
        Console.WriteLine("Oikea luku on suurempi!");
    }
    else if (arvaus > oikea)
    {
        Console.WriteLine("Oikea luku on pienempi!");
    }
    else
    {
        Console.WriteLine("Hienoa! Arvasit oikein ja voitit pelin!");
        break;
    }
}

Console.WriteLine("Peli on päättynyt.");
