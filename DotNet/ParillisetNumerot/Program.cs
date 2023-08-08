// tapa 1
for (int laskuri = 1; laskuri <= 20; laskuri++)
{
    if (laskuri % 2 == 0)
    {
        Console.WriteLine(laskuri);
    }
}

Console.WriteLine("--------------");

// tapa 2
for (int laskuri = 2; laskuri <= 20; laskuri = laskuri + 2)
{
    Console.WriteLine(laskuri);
}

Console.WriteLine("--------------");

// tapa 3
int laskuri2 = 2;
while (laskuri2 <= 20) {
    Console.WriteLine(laskuri2);
    laskuri2 = laskuri2 + 2;
}
