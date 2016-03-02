using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Mapping
{
    public class Ex1_LoopMapping
    {
        public IEnumerable<string> GetAllShipNames(SampleData data)
        {
            //This function shall simply return a collection of all ships' names.

            var results = new List<string>();
            for(int i=0; i<data.Ships.Count(); i++) //let's try for loop
            {
                results.Add(data.Ships[i].Name);
            }

            return results;
        }
    }       
}
