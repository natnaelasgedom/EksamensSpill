namespace EksamenSpill
{
    public class Gjenstand
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }

        public Gjenstand(string navn, int pris)
        {
            Navn = navn;
            Pris = pris;
        }
    }
}