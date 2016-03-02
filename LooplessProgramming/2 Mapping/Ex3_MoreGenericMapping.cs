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
       
            return ApplyProjection(data.Fleets.Values, fleet => fleet.Name);

        }

        public IEnumerable<int> GetShipsCrewsAmounts(SampleData data)
        {
            //The result shall be collection of numbers of crewmembers of each ship

            return ApplyProjection(data.Ships, ship => ship.Crew);
        }

        private IEnumerable<TResult> ApplyProjection<T, TResult>(IEnumerable<T> collection, Func<T, TResult> elementMapping)
        {
            var results = new List<TResult>();
            var enumerator = collection.GetEnumerator();


            //not a good idea to use for to iterate over IEnuerable, but wanted to try it
            for (
                var hasNext = enumerator.MoveNext(); 
                hasNext != false; 
                hasNext = enumerator.MoveNext()
            )
            {
                results.Add(elementMapping(enumerator.Current));
            }

            return results;
        }
    }
}
