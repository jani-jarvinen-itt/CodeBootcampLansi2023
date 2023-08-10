/*
Algoritmi:

1. Tietokone arpoo numeron 1-20.
2. Kysy pelaajalta luku.
3. Tarkista pelaajan arvaus:
   a. Jos oikein, pelaaja voittaa. Lopeta peli.
   b. Jos oikea luku on pienempi, kerro se.
   c. Jos oikea luku on suurempi, kerro se.
4. Mene kohtaan 2, jos arvauskertoa (3 kpl) on vielä jäljellä.
*/

const int SuurinLuku = 20;
const int ArvauskertojenMäärä = 3;

Random satunnainen = new();
int oikea = satunnainen.Next(1, SuurinLuku + 1);
// Console.WriteLine(oikea);

for (int arvauskerta = 0; arvauskerta < ArvauskertojenMäärä; arvauskerta++)
{
    int arvaus = KysyKäyttäjältäLuku();    

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

int KysyKäyttäjältäLuku()
{
    while (true)
    {
        try
        {
            Console.WriteLine($"Anna arvauksesi välillä 1-{SuurinLuku}:");
            string syöte = Console.ReadLine();
            int arvaus = int.Parse(syöte);

            if ((arvaus < 1) || (arvaus > SuurinLuku))
            {
                Console.WriteLine($"Arvauksen tulee olla välillä 1-{SuurinLuku}.");
            }
            else
            {
                return arvaus;
            }
        }
        catch
        {
            Console.WriteLine("Antamasi syöte oli virheellinen.");
        }
    }
}