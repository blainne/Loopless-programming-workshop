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

            return null;

        }

        public IEnumerable<Ex1_ShipAndCommander> GetShipsAssignmentInfo(SampleData data)
        {
            //each ship shall be translated into an instance of Ex1_ShipAndCommander class

            return null;
        }
    }

    public class Ex1_ShipAndCommander
    {
        public string ShipName { get; set; }
        public string CaptainName { get; set; }
    }
}
