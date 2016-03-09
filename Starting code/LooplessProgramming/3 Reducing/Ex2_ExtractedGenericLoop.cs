using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming.Reducing
{
    public class Ex2_ExtractedGenericLoop
    {
        public SpaceWarship GetSmallestShip(SampleData data)
        {
            //A ship with smallest crew shall be returned here;

            return CalculateValue(
                        data.Ships, 
                        data.Ships.First(),
                        GetSmallerShip);
        }

        private SpaceWarship GetSmallerShip(SpaceWarship ship1, SpaceWarship ship2)
        {
            return (ship1.Crew < ship2.Crew)
                    ? ship1
                    : ship2;
        }

        public string GetCommaSeparatedCommandersNames(SampleData data)
        {
            //This shall be a single string in form "name1,name2,name3,"
            //Pay attention to the trailing comma - it's there for Your convenience

            return CalculateValue(
                        data.Commanders,
                        "",
                        (names, next) => names + next.Name + ",");
        }

        public Result CalculateValue<Result, Model>(
            IEnumerable<Model> collection,
            Result initial, 
            Func<Result, Model, Result> calcFun)
        {
            var result = initial;
            foreach(var element in collection)
            {
                result = calcFun(result, element);
            }

            return result;
        }
    }
}
