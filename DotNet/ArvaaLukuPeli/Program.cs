/*
Algoritmi:

1. Tietokone arpoo numeron 1-20.
2. Kysy pelaajalta luku.
3. Tarkista pelaajan arvaus:
   a. Jos oikein, pelaaja voittaa. Lopeta peli.
   b. Jos oikea luku on pienempi, kerro se.
   c. Jos oikea luku on suurempi, kerro se.
4. Mene kohtaa 2, jos arvauskertoa (3 kpl) on vielä jäljellä.
*/

Random satunnainen = new();
int oikea = satunnainen.Next(1, 21);
// Console.WriteLine(oikea);

for (int arvauskerta = 0; arvauskerta < 3; arvauskerta++)
{
    int arvaus = 0;
    while (true)
    {
        try
        {
            Console.WriteLine("Anna arvauksesi välillä 1-20:");
            string syöte = Console.ReadLine();
            arvaus = int.Parse(syöte);

            if ((arvaus < 1) || (arvaus > 20))
            {
                Console.WriteLine("Arvauksen tulee olla välillä 1-20.");
            }
            else
            {
                break;
            }
        }
        catch
        {
            Console.WriteLine("Antamasi syöte oli virheellinen.");
        }
    }

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
