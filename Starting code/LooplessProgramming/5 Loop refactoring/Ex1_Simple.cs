using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Model;

namespace LooplessProgramming.LoopRefactoring
{

    public class Ex1_Simple
    {
        //Refactor these methods to use map/filter/reduce instead of loops

        public IEnumerable<SpaceWarship> GetShipsWithYoungCaptains(SampleData data)
        {
            var result = new List<SpaceWarship>();
            foreach (var ship in data.Ships)
            {
                if (ship.Captain.YearsOfService <= 25)
                    result.Add(ship);
            }

            return result;
        }

        public IEnumerable<string> GetNonNullNorEmptyStrings(List<string> inputData)
        {
            var correctStrings = new List<string>();

            for (int i = 0; i < inputData.Count; i++)
            {
                if (!(string.IsNullOrEmpty(inputData[i])))
                {
                    correctStrings.Add(inputData[i]);
                }
            }

            return correctStrings;
        }

        public IEnumerable<int> GetSquares(List<int> numbers)
        {
            //A crime is happening here. We're modifying original collection. Can You fix it?
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i]*numbers[i];
            }

            return numbers;
        }

        public bool AreAllStringsLongerThan5(List<string> input)
        {
            foreach (var text in input)
            {
                if (text.Length <= 5) return false;
            }

            return true;
        }
    }
}
