using System;
using System.Collections.Generic;
//using System.Linq; - we want to use our own methods instead of standard ones
using LooplessProgramming.MyLinq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming.LanguageSupport
{
    public class Ex3_LinqSupport
    {
        //Its easy to leverage query syntax using Your own map and filer functions.
        //Just name Your methods Select and Where, make sure Your namespace is visible
        //and You're ready to go.

        public IEnumerable<string> GetNamesOfBattleships(SampleData data)
        {
            return
                from s in data.Ships
                where s.ShipClass == WarshipClass.Battleship
                select s.Name;

        }
    }
}
