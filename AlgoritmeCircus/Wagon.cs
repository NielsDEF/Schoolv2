using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeCircus
{
    class Wagon
    {
        public int Punten { get; set; } = 10;

        public List<Dier> Dieren { get; } = new List<Dier>();


        public bool KanDierVerdelen(Dier vince)
        {
            //loop
            foreach (Dier d in Dieren)
            {
                if (vince.Punten >= d.Punten && vince.AlgemeneSoort == DierSoorten.Carnivoor)
                {
                    return false;
                }
                if (vince.Punten <= d.Punten && d.AlgemeneSoort == DierSoorten.Carnivoor)
                {
                    return false;
                }
            }

            return (Punten > vince.Punten);
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

        public void VoegDierToe(Dier vince)
        {
            Dieren.Add(vince);
            Punten -= vince.Punten;
        }





    }
}
