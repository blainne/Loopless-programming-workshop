using System;
using System.Collections.Generic;
using System.Linq;
using LooplessProgramming.Model;

namespace LooplessProgramming.Filtering
{
    public class Ex3_MoreGenericFiltering
    {
        //Like before we want to have a single method that will do the filtering
        //and will be reused in all below public methods

        public IEnumerable<Person> GetCaptainsWithMostResponsiblity(SampleData data)
        {
            //All captains of ships with at least 1500 crew member shall be returned

            return GetElementsSatisfyingCondition(
                data.Commanders,
                commander => ThereIsAShipWithThisCaptainAndEnoughCrew(data, commander));
        }

        private static bool ThereIsAShipWithThisCaptainAndEnoughCrew(SampleData data, Person commander)
        {
            return data.Ships.Any(
                                ship => ship.Captain.Name == commander.Name
                                && ship.Crew >= 1500);
        }

        public IEnumerable<Fleet> GetMultishipFleets(SampleData data)
        {
            return GetElementsSatisfyingCondition(
                        data.Fleets.Values, 
                        fleet => fleet.Ships.Count() > 1);
        }

        private List<T> GetElementsSatisfyingCondition<T>(IEnumerable<T> collection, Func<T, bool> condition)
        {
            var result = new List<T>();
            foreach (var elem in collection)
            {
                if (condition(elem))
                    result.Add(elem);
            }
            return result;
        }
    }
}
