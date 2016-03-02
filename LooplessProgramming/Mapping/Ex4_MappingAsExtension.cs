using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Mapping
{
    public static class Ex4_MappingAsExtension
    {
        //As previously, we now want to make our mapping method more convenient.
        //After Your done with it, implement the public method in the class below.

        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> collection, Func<T, TResult> elementMapping)
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

    public class Ex4_MappingData
    {
        public IEnumerable<Ex4_CommanderInfo> GetFleetsCommandersReports(SampleData data)
        { 
            //Map each fleet into number of ships that it has
            return 
                data.Fleets.Values
                .Map(f => new Ex4_CommanderInfo(
                                    f.Commander.Name,
                                    f.Commander.YearsOfService,
                                    f.Ships.Count()));
        }
    }

    public class Ex4_CommanderInfo
    {
        public string CommanderName { get; private set; }
        public int CommanderExperience { get; private set; }
        public int ShipsUnderCommand { get; private set; }

        public Ex4_CommanderInfo(
            string commanderName, 
            int commanderExperience, 
            int shipsUnderCommand)
        {
            ShipsUnderCommand = shipsUnderCommand;
            CommanderExperience = commanderExperience;
            CommanderName = commanderName;
        }
    }
}
