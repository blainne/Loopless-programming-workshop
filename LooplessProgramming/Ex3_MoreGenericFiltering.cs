using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming
{
    public class Ex3_MoreGenericFiltering
    {
        //Like before we want to have a single method that will do the filtering
        //and will be reused in all below public methods

        public IEnumerable<Person> GetCaptainsWithMostResponsiblity(SampleData data)
        {
            //All captains of ships with at least 1500 crew member shall be returned

            return GetShipsSatisfyingCondition(data, ship => ship.Crew >= 1500);
        }


        public IEnumerable<Fleet> GetMultishipFleets(SampleData data)
        {
            //Return all fleets with more than 1 ship. 

            return null;
        }

        private List<Person> GetShipsSatisfyingCondition(SampleData data, Func<SpaceWarship, bool> condition)
        {
            var result = new List<Person>();
            foreach (var ship in data.Ships)
            {
                if (condition(ship))
                    result.Add(ship.Captain);
            }
            return result;
        }
    }
}
