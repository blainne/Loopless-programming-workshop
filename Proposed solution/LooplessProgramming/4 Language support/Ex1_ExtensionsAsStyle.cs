using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.MyLinq;
using LooplessProgramming.Model;

namespace LooplessProgramming.LanguageSupport
{
    public class Ex1_ExtensionsAsStyle
    {
        //All methods in this class shall calculate same result but using a different style.


        public int TotalCrewOnDestroyers_1(SampleData data)
        {
            //This is a dummy implementation - not a good style
            return
                MFR.Reduce(
                    MFR.Map(
                        MFR.Filter(
                            data.Ships, 
                            s => s.ShipClass == WarshipClass.Destroyer),
                        s => s.Crew),
                    0,
                    (acc, shipcrew) => acc + shipcrew);
        }

        public int TotalCrewOnDestroyers_2(SampleData data)
        {
            //this method shall introduce variables that hold intermediary results,
            //but still use normal static forms of methods

            var destroyers = MFR.Filter(data.Ships, s => s.ShipClass == WarshipClass.Destroyer);
            var destroyersCrews = MFR.Map(destroyers, s => s.Crew);
            var result = MFR.Reduce(destroyersCrews, 0, (acc, shipcrew) => acc + shipcrew);

            return result;
        }

        public int TotalCrewOnDestroyers_3(SampleData data)
        {
            //this version should make use of map, filter and reduce as extension methods
            return 
                data.Ships
                    .Filter(s => s.ShipClass == WarshipClass.Destroyer)
                    .Map(s => s.Crew)
                    .Reduce(0, (acc, shipcrew) => acc + shipcrew);
        }

        public int TotalCrewOnDestroyers_4(SampleData data)
        {
            //and now, implement the same calculation with a loop

            var result = 0;
            foreach(var s in data.Ships)
                if(s.ShipClass == WarshipClass.Destroyer)
                    result = result + s.Crew;

            return result;
        }
    }
}
