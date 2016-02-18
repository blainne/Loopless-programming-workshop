using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming
{
    public class Ex2_ExtractedLoop
    {
        //In this exercise we want to reuse the same loop construct.
        //Only a single loop shall be present in this class.

        private SampleData data = new SampleData();

        public IEnumerable<SpaceWarship> GetBigCruisers()
        {
            //This function should return a collection of ships
            //that belong to cruiser class and have at least 2000 crew members.

            //Use a loop to implement it.

            var result = new List<SpaceWarship>();
            foreach(var ship in data.Ships)
            {
                if(ship.ShipClass == WarshipClass.Cruiser
                    && ship.Crew >= 2000)
                    result.Add(ship);
            }

            return result;

        }

        public IEnumerable<SpaceWarship> GetFastReactingDestroyers()
        {
            //This function should return a collection of ships
            //that belong to destroyer class and are members of quick reaction fleet.

            //Use a loop to implement it.

            return null;

        }
    }
}
