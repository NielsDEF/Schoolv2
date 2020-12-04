using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeCircus
{
    class Wagon
    {
        public int Punten { get; set; } = 11;

        public List<Dier> Dieren { get; } = new List<Dier>();


        public bool KanDierVerdelen(Dier nieuwdier)
        {
            //loop
            foreach (Dier d in Dieren)
            {
                if (nieuwdier.Punten >= d.Punten && nieuwdier.AlgemeneSoort == DierSoorten.Carnivoor)
                {
                    return false;
                }
                if (nieuwdier.Punten <= d.Punten && d.AlgemeneSoort == DierSoorten.Carnivoor)
                {
                    return false;
                }
            }

            return (Punten > nieuwdier.Punten);
        }

        public override string ToString()
        {
            string tekst = "wagon: ";
            foreach (Dier d in Dieren)
            {
                if (Dieren.IndexOf(d) != Dieren.Count - 1)
                    tekst += d.ToString() + ", ";
                else
                    tekst += d.ToString();
            }
            return tekst;
        }

        public void VoegDierToe(Dier nieuwdier)
        {
            Dieren.Add(nieuwdier);
            Punten -= nieuwdier.Punten;
        }





    }
}
