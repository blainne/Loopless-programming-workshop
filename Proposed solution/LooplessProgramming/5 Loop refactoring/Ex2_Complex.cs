using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.MyLinq;

namespace LooplessProgramming.LoopRefactoring
{
    public class Ex2_Complex
    {
        //Refactor these methods to use map/filter/reduce instead of loops
        public bool AreAllNonEmptyStringsLongerThan5(List<string> input)
        {
            return input
                    .Filter(s => !string.IsNullOrEmpty(s))
                    .Reduce(
                        true,
                        (acc, str) =>
                            (str.Length >= 5) && acc);

        }

        public int GetSumOfNumbers(List<string> numbersAsText)
        {
            return numbersAsText
                .Filter(s => !string.IsNullOrEmpty(s))
                .Map(s => ParsedOrNull(s))
                .Filter(n => n.HasValue)
                .Reduce(0, (acc, num) => acc + num.Value);
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
