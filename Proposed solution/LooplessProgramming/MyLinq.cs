using System;
using System.CodeDom;
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

            iteration:
            if (!enumerator.MoveNext()) goto finish;
            var elem = enumerator.Current;
            if (condition(elem))
                result.Add(elem);

            goto iteration;

            finish:
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


            iteration:
            var hasNext = enumerator.MoveNext();
            if(!hasNext) goto finish;

            results.Add(elementMapping(enumerator.Current));
            goto iteration;


            finish:
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
            var enumerator = collection.GetEnumerator();

            iteration:
            var hasNext = enumerator.MoveNext();
            if (!hasNext) goto finish;
            result = calcFun(result, enumerator.Current);
           
            goto iteration;

            finish:
            return result;
        }

    }
}
