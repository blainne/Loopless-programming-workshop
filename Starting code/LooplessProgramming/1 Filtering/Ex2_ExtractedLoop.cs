using System;
using System.Collections.Generic;
using System.Linq;
using LooplessProgramming.Model;

namespace LooplessProgramming.Filtering
{
    public class Ex2_ExtractedLoop
    {
        //In this exercise we want to reuse the same loop construct.
        //Only a single loop shall be present in this class.
        //You can use helepr methods that are ready for You.


        public IEnumerable<SpaceWarship> GetBigCruisers(SampleData data)
        {
            //This function should return a collection of ships
            //that belong to cruiser class and have at least 2000 crew members.

            return null;

        }

        public IEnumerable<SpaceWarship> GetQuickReactingDestroyers(SampleData data)
        {
            //This function should return a collection of ships
            //that belong to destroyer class and are members of quick reaction fleet.


            return null;
        }



        private static bool IsCruiserWithCrewOver2000(SpaceWarship ship)
        {
            return ship.ShipClass == WarshipClass.Cruiser
                   && ship.Crew >= 2000;
        }

        private bool IsDestroyerInQuickReactionFleet(SampleData data, SpaceWarship ship)
        {
            return
                ship.ShipClass == WarshipClass.Destroyer
                && data.Fleets[SampleData.QuickReactionFleet].Ships.Contains(ship);
        }
    }
}
