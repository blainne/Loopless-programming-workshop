using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming
{
    public class Ex1_LoopFiltering
    {
        private SampleData data = new SampleData();
        public IEnumerable<SpaceWarship> GetShipsWithYoungCaptains()
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
