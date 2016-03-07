using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming._3_Reducing
{
    public static class Ex3_ReducingAsExtension
    {
        //This shall be simple. 
        //Just take Your reducing function and turn it into an extension method.
        //After that use it to implement method in the class below.

        public static Result Reduce<Result, Model>(
            this IEnumerable<Model> collection,
            Result initial,
            Func<Result, Model, Result> calcFun)
        {
            var result = initial;
            foreach (var element in collection)
            {
                result = calcFun(result, element);
            }

            return result;
        }
    }

    public class Ex3_ReducingData
    {
        public int GetCumulativeYearsOfService(SampleData data)
        {
            //Just calculate a sum of years of service over all ships captains

            return data.Ships.Reduce(0, (acc, ship) => acc + ship.Captain.YearsOfService);
        }     
    }
}
