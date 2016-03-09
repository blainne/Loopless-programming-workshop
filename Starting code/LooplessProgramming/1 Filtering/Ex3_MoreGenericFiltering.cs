using System;
using System.Collections.Generic;
using System.Linq;
using LooplessProgramming.Model;

namespace LooplessProgramming.Filtering
{
    public class Ex3_MoreGenericFiltering
    {
        //Like before we want to have a single method that will do the filtering
        //and will be reused in all below public methods.
        //As before, You can find some useful helper method here.

        public IEnumerable<Person> GetCaptainsWithMostResponsiblity(SampleData data)
        {
            //All captains of ships with at least 1500 crew member shall be returned

            return null;
        }

        private static bool ThereIsAShipWithThisCaptainAndEnoughCrew(SampleData data, Person commander)
        {
            return data.Ships.Any(
                                ship => ship.Captain.Name == commander.Name
                                && ship.Crew >= 1500);
        }

        public IEnumerable<Fleet> GetMultishipFleets(SampleData data)
        {
            return null;
        }

    }
}
