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
        //Note also, how implicitly typed variables ('var') cooperate with anonymous objects

        public IEnumerable<string> AddRandomNumbersToShipsAndPickPositiveOnes(SampleData data)
        {
            //each ship shall have a random number assigned,
            //then list of strings in form "{ship name}: {number}"
            //only for ships with a positive number shall be returned

            //use anonymous object to first map ships into ship name and number,
            //then filter out negative ones and zeros, then map into resulting string
    
            var rand = new Random();

            return data.Ships
                .Map(ship => new {Name = ship.Name, Number = rand.Next()})
                .Filter(sn => sn.Number > 0)
                .Map(sn => String.Format("{0}: {1}", sn.Name, sn.Number));
        }
    }
}
