using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeCircus
{
    class Trein
    {
        public List<Wagon> Wagons { get; set; } = new List<Wagon>();

        public void VerdeelDier(Dier d)
        {
            List<Wagon> temp = new List<Wagon>();

            foreach (Wagon w in Wagons)
            {
                if (w.KanDierVerdelen(d))
                    temp.Add(w);
            }

            if (temp.Count >= 1)
            {

                temp.First(n => n.Punten == temp.Min(z => z.Punten)).VoegDierToe(d);
            }
            else 
            {
                Wagon w = new Wagon();
                w.VoegDierToe(d);
                Wagons.Add(w);
            }
        }


    }
}
