namespace OlioOhjelmointi
{
    public class Auto
    {
        // ominaisuudet (property)
        public string Merkki { get; set; }

        public string Väri { get; set; }

        public int Nopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        // toiminnallisuudet (method)
        public void Käynnistä()
        {
            MoottoriKäynnissä = true;
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
        }

        public void Kiihdytä()
        {
            if (MoottoriKäynnissä)
            {
                // Nopeus = Nopeus + 10;
                Nopeus += 10;

                if (Nopeus > 200)
                {
                    Nopeus = 200;
                }
            }
        }

        public void Jarruta()
        {
            Nopeus -= 10;

            if (Nopeus < 0)
            {
                Nopeus = 0;
            }
        }
    }
}