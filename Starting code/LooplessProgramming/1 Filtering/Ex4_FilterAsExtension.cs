using System;
using System.Collections.Generic;
using LooplessProgramming.Model;

namespace LooplessProgramming.Filtering
{
    public static class Ex4_FilterAsExtension
    {
        //Your filtering method (the one that contains for loop) shall be pretty much done.
        //Now, take it and turn it into an extension method,
        //so it can be used in a more convenient and readable way

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var result = new List<T>();
            var enumerator = collection.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var elem = enumerator.Current;
                if (condition(elem))
                    result.Add(elem);
            }
            return result;
        }


        //Use newly created to implement our data processing methods in the class below
        public class Ex4_FilteringData
        {
            public IEnumerable<SpaceWarship> GetAllBattleships(SampleData data)
            {
                //This method, as it's name implies, shall simply return all battleships.
                return data.Ships.Filter(ship => ship.ShipClass == WarshipClass.Battleship);
            }
            
            public IEnumerable<Person> GetCommandersOnM(SampleData data)
            {
                //Return all commanders whose names start with letter M or m
                return data.Commanders.Filter(person => person.Name.ToLower().StartsWith("m"));
            }
        }
    }
}
