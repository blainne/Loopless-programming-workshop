using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming
{
    public class Ex3_MoreGenericFiltering
    {
        //Like before we want to have a single method that will do the filtering
        //and will be reused in all below public methods

        public IEnumerable<Person> GetCaptainsWithMostResponsiblity()
        {
            //All captains of ships with more than 1500 crew member shall be returned

            return null;
        }


        public IEnumerable<Fleet> GetMultishipFleets()
        {
            //Return all fleets with more than 1 ship. 

            return null;
        }
    }
}
