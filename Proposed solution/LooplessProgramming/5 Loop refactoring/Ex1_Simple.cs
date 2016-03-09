using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;
using LooplessProgramming.MyLinq;

namespace LooplessProgramming.LoopRefactoring
{

    public class Ex1_Simple
    {
        //Refactor these methods to use map/filter/reduce instead of loops

        public IEnumerable<SpaceWarship> GetShipsWithYoungCaptains(SampleData data)
        {
           return data.Ships.Filter(s => s.Captain.YearsOfService <= 25);
        }

        public IEnumerable<string> GetNonNullNorEmptyStrings(List<string> inputData)
        {
            return inputData.Filter(s => !string.IsNullOrEmpty(s));
        }

        public IEnumerable<int> GetSquares(List<int> numbers)
        {
            return numbers.Map(n => n*n);
        }

        public bool AreAllStringsLongerThan5(List<string> input)
        {
            return input.Reduce(
                true,
                (acc, str) =>
                    (str.Length >= 5) && acc);
        }
    }
}
