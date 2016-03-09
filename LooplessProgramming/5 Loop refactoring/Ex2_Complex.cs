using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.LoopRefactoring
{
    public class Ex2_Complex
    {
        //Refactor these methods to use map/filter/reduce instead of loops
        public bool AreAllNonEmptyStringsLongerThan5(List<string> input)
        {
            foreach (var text in input)
            {
                if (string.IsNullOrEmpty(text)) continue;
                if (text.Length <= 5) return false;
            }

            return true;
        }

        public int GetSumOfNumbers(List<string> numbersAsText)
        {
            //You can use ParsedOrNull during refactoring
            var sum = 0;
            foreach (var text in numbersAsText)
            {
                if (string.IsNullOrEmpty(text)) continue;

                int num = 0;
                var parsed = int.TryParse(text, out num);

                if (parsed) sum += num;
            }

            return sum;
        }

        
        private int? ParsedOrNull(string s)
        {
            int result = 0;
            return
                (int.TryParse(s, out result))
                ? new int?(result)
                : null;
        }
    }
}
