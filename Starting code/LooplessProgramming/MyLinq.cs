using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.MyLinq
{
    public static class MFR
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var result = new List<T>();
            var enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var elem = enumerator.Current;
                if (condition(elem))
                    result.Add(elem);
            }
            return result;
        }
        

        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            return collection.Filter(condition);
        }

        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> collection, Func<T, TResult> elementMapping)
        {
            var results = new List<TResult>();
            var enumerator = collection.GetEnumerator();


            //not a good idea to use for to iterate over IEnuerable, but wanted to try it
            for (
                var hasNext = enumerator.MoveNext();
                hasNext != false;
                hasNext = enumerator.MoveNext()
            )
            {
                results.Add(elementMapping(enumerator.Current));
            }

            return results;
        }

        public static IEnumerable<TResult> Select<T, TResult>(this IEnumerable<T> collection, Func<T, TResult> elementMapping)
        {
            return collection.Map(elementMapping);
        }

        public static Result Reduce<Result, Model>(
            this IEnumerable<Model> collection,
            Result initial,
            Func<Result, Model, Result> calcFun)
        {
            var result = initial;
            foreach (var element in collection)
            {
                result = calcFun(result, element);
            }

            return result;
        }

    }
}
