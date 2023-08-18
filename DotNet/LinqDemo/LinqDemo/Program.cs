// lukutaulukko (array)
int[] luvut = { 5, 11, 8, 4, 12, 6, 3, 7, 1 };

// tulosta viittä suuremmat luvut numerojärjestyksessä
var viittäSuuremmat = from l in luvut
                      where l > 5
                      orderby l
                      select l;

foreach (int luku in viittäSuuremmat)
{
    Console.WriteLine(luku);
}
