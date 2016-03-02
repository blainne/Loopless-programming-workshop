using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Reducing
{
    public class Ex1_LoopReducing
    {
        public int GetTotalCrew(SampleData data)
        {
            var count = 0;
            foreach (var s in data.Ships)
            {
                count += s.Crew;
            }

            return count;
        }
    }
}
