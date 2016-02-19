using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming
{
    public class Ex2_ExtractedLoop
    {
        //In this exercise we want to reuse the same loop construct.
        //Only a single loop shall be present in this class.


        public IEnumerable<SpaceWarship> GetBigCruisers(SampleData data)
        {
            //This function should return a collection of ships
            //that belong to cruiser class and have at least 2000 crew members.



            return
                GetShipsSatisfyingCondition(data, IsCruiserWithCrewOver2000);

        }

        public IEnumerable<SpaceWarship> GetQuickReactingDestroyers(SampleData data)
        {
            //This function should return a collection of ships
            //that belong to destroyer class and are members of quick reaction fleet.


            return 
                GetShipsSatisfyingCondition(
                    data, 
                    (ship) => IsDestroyerInQuickReactionFleet(data, ship)
                );
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


        private List<SpaceWarship> GetShipsSatisfyingCondition(SampleData data, Func<SpaceWarship, bool> condition)
        {
            var result = new List<SpaceWarship>();
            foreach (var ship in data.Ships)
            {
                if (condition(ship))
                    result.Add(ship);
            }
            return result;
        }
    }
}
