using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming.Reducing
{
    public class Ex1_LoopReducing
    {
        public int GetTotalCrew(SampleData data)
        {
            //This method shall return number of all crewmembers on all ships
            //Use loop to implement it.

            var count = 0;
            foreach (var s in data.Ships)
            {
                count += s.Crew;
            }
            return count;
        }

        public bool AreThereScouts(SampleData data)
        {
            //This method has to answer whether there are any scout class ships.
            //Use loop to implement it.
            foreach (var ship in data.Ships)
            {
                if (ship.ShipClass == WarshipClass.Scout)
                    return true;
            }
            return false;
        }
    }
}
