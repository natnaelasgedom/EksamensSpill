namespace EksamenSpill
{
    public class Sted
    {
        public string Beskrivelse { get; set; }
        public Skattekiste Skattekiste { get; set; }

        public Sted(string beskrivelse)
        {
            Beskrivelse = beskrivelse;
        }

        public Skattekiste PlasserSkattekiste(Skattekiste skattekiste)
        {
            Skattekiste = skattekiste;
            return Skattekiste;
        }
    }
}