using System;
using System.Collections.Generic;

static class Snippets
{
    public static IEnumerable<int> GetSmallNumbers()
    {
        yield return 1;
        yield return 6;
        yield return 8;
    }

    public static IEnumerable<T> Filter<T> (IEnumerable<T> sequence, Predicate<T> filter)
    {
        foreach(var item in sequence)
            if (filter(item))
                yield return item;
    }

    public static T First<T> (IEnumerable<T> sequence)
    {
        var enumerator = sequence.GetEnumerator();
        enumerator.MoveNext();
        return enumerator.Current;
    }

    public static int Main(string[] args)
    {
        Predicate<int> isOdd = (x) => x % 2 == 0;

        Console.WriteLine("First odd small number is {0}", First(Filter(GetSmallNumbers(), isOdd)));

        return 0;
    }
}