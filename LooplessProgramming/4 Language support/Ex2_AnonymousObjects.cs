using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.MyLinq;

namespace LooplessProgramming._4_Language_support
{
    public class Ex2_AnonymousObjects
    {
        //This exercise shall present how convenient anonymous objects are.
        //They were introduced exactly for the reason of making linq experience better.

        public IEnumerable<string> AddRandomNumbersToShipsAndPickPositiveOnes_1(SampleData data)
        {
            //each ship shall have a random number assigned,
            //then list of strings in form "{ship name}: {number}"
            //only for ships with odd number shall be returned

            var rand = new Random();

            return data.Ships
                .Map(ship => new ShipAssignment(ship.Name, rand.Next()))
                .Filter(sn => sn.Number % 2 == 1)
                .Map(sn => String.Format("{0}: {1}", sn.ShipName, sn.Number));
        }

        public IEnumerable<string> AddRandomNumbersToShipsAndPickPositiveOnes_2(SampleData data)
        { 
            //Use anonymous object instead of ShipAssignment class
    
            var rand = new Random();

            return data.Ships
                .Map(ship => new {Name = ship.Name, Number = rand.Next()})
                .Filter(sn => sn.Number % 2 == 1)
                .Map(sn => String.Format("{0}: {1}", sn.Name, sn.Number));
        }

        private class ShipAssignment
        {
            public ShipAssignment(string shipName, int number)
            {
                Number = number;
                ShipName = shipName;
            }

            public string ShipName { get; private set; }
            public int Number { get; private set; }
        }
    }
}
