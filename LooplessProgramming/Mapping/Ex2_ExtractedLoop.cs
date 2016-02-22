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

            var results = new List<int>();
            for (int i = 0; i < data.Ships.Count(); i++)
            {
                results.Add(data.Ships[i].Captain.YearsOfService);
            }

            return results;
        }

        public IEnumerable<Ex1_ShipAndCommander> GetShipsAssignmentInfo(SampleData data)
        {
            //each ship shall be translated into an instance of Ex1_ShipAndCommander class

            var results = new List<Ex1_ShipAndCommander>();
            for (int i = 0; i < data.Ships.Count(); i++)
            {
                results.Add(new Ex1_ShipAndCommander
                {
                    ShipName = data.Ships[i].Name,
                    CaptainName = data.Ships[i].Captain.Name
                });
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
