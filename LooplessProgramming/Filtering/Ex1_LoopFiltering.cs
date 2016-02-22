using System.Collections.Generic;
using LooplessProgramming.Model;

namespace LooplessProgramming.Filtering
{
    public class Ex1_LoopFiltering
    {
        public IEnumerable<SpaceWarship> GetShipsWithYoungCaptains(SampleData data)
        {
            //This function should return a collection of ships
            //that are commanded by captains with service 
            //no longer than 25 years.

            //Use a loop to implement it.

            var result = new List<SpaceWarship>();
            foreach (var ship in data.Ships)
            {
                if(ship.Captain.YearsOfService <= 25)
                    result.Add(ship);
            }

            return result;

        }
    }
}
