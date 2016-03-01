using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming.Mapping
{
    public class Ex3_MoreGenericMapping
    {
        //Like before we want to have a single method that will do the mapping.
        //and will be reused in all below public methods

        public IEnumerable<string> GetFleetsNames(SampleData data)
        {
            //We want to return a collection of names of all fleets.

            return null;

        }

        public IEnumerable<int> GetShipsCrewsAmounts(SampleData data)
        {
            //The result shall be collection of numbers of crewmembers of each ship

            return null;
        }

        private static List<TResult> ApplyProjection<T, TResult>(List<T> collection, Func<T, TResult> elementMapping)
        {
            var results = new List<TResult>();
            for (int i = 0; i < collection.Count(); i++)
            {
                results.Add(elementMapping(collection[i]));
            }

            return results;
        }
    }
}
