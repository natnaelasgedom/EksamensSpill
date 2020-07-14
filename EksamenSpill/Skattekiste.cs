using System;
using System.Collections.Generic;

namespace EksamenSpill
{
    public class Skattekiste
    {
        public List<Gjenstand> Gjenstander { get; set; }

        public Skattekiste(int kapasitet)
        {
            Gjenstander = new List<Gjenstand>(kapasitet);
        }

        public Gjenstand TaUtGjenstand()
        {
            int randomIndex = new Random().Next(Gjenstander.Count);
            Gjenstand gjenstand = Gjenstander[randomIndex];
            Gjenstander.RemoveAt(randomIndex);
            return gjenstand;
        }

        public decimal LeggInnGjenstand(Gjenstand gjenstand)
        {
            Gjenstander.Add(gjenstand);
            decimal minimum = (decimal) 0.9, maximum = (decimal) 1.1;
            return (decimal) new Random().NextDouble() * gjenstand.Pris * (maximum - minimum) + gjenstand.Pris *minimum; 
        }
    }
}