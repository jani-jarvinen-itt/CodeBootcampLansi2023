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
            // ...
        }

        public void Sammuta()
        {
            // ...
        }

        public void Kiihdytä()
        {
            // ...
        }

        public void Jarruta()
        {
            // ...
        }
    }
}