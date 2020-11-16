using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeCircus
{
    class Dier
    {
        public int Punten
        {
            get
            {
                switch (Soort)
                {
                    case DierSoorten.KleineCarnivoor:
                    case DierSoorten.KleineHerbivoor:
                        return 1;
                    case DierSoorten.MiddelCarnivoor:
                    case DierSoorten.MiddelHerbivoor:
                        return 3;
                    case DierSoorten.GroteCarnivoor:
                    case DierSoorten.GroteHerbivoor:
                        return 5;
                    default:
                        return 1;
                }
            }

        }
        public DierSoorten Soort { get; set; }

        public DierSoorten AlgemeneSoort { get; set; }

        public Dier(DierSoorten soort)
        {
            Soort = soort;
            if (soort == DierSoorten.KleineCarnivoor || soort == DierSoorten.MiddelCarnivoor || soort ==
                DierSoorten.GroteCarnivoor)
            {
                AlgemeneSoort = DierSoorten.Carnivoor;
            }
            else
            {
                AlgemeneSoort = DierSoorten.Herbivoor;
            }
        }
        public override string ToString()
        {
            return Soort.ToString();
        
        }
    }
}
