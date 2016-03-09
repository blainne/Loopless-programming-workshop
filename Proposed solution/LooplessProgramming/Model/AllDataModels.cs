using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Model
{
    public class SpaceWarship
    {
        public WarshipClass ShipClass { get; set; }
        public int Crew { get; set; }
        public Person Captain { get; set; }
        public string Name { get; set; }
    }

    public class Fleet
    {
        public string Name { get; set; }
        public IEnumerable<SpaceWarship> Ships {get; set;}
        public Person Commander { get; set; }

    }

    public class Person
    {
        public string Name { get; set; }
        public int YearsOfService { get; set; }
    }

    public enum WarshipClass
    {
        Destroyer,
        Cruiser,
        Battleship,
        Monitor,
        Scout,
    }
}
