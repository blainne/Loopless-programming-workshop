using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Mapping
{
    public class Ex2_ExtractedLoop
    {
        //In this exercise we want to reuse the same loop construct.
        //Only a single loop shall be present in this class.

        public IEnumerable<int> GetShipsCaptainsExperience(SampleData data)
        {
            //we want to map list of ships into 
            //list of ship's captain's experience (years of service)

            return ApplyProjection(data.Ships, ship => ship.Captain.YearsOfService);
            
        }

        public IEnumerable<Ex1_ShipAndCommander> GetShipsAssignmentInfo(SampleData data)
        {
            //each ship shall be translated into an instance of Ex1_ShipAndCommander class

            
            return ApplyProjection(
                    data.Ships,
                    ship => new Ex1_ShipAndCommander
                            {
                                ShipName = ship.Name,
                                CaptainName = ship.Captain.Name
                            }
                );
        }

        private static List<T> ApplyProjection<T>(List<SpaceWarship> ships, Func<SpaceWarship, T> elementMapping)
        {
            var results = new List<T>();
            for (int i = 0; i < ships.Count(); i++)
            {
                results.Add(elementMapping(ships[i]));
            }

            return results;
        }

    }

    public class Ex1_ShipAndCommander
    {
        public string ShipName { get; set; }
        public string CaptainName { get; set; }
    }
}
