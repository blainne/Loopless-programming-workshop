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
            
            return int.MinValue;
        }

        public int TotalCrewOnDestroyers_3(SampleData data)
        {
            //this version should make use of map, filter and reduce as extension methods
            return int.MinValue;
        }

        public int TotalCrewOnDestroyers_4(SampleData data)
        {
            //and now, implement the same calculation with a loop

            return int.MinValue;
        }
    }
}
