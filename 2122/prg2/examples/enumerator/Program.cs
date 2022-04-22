using System;
using System.Linq;

using System.Diagnostics;
using System.Collections.Generic;

delegate int IntFunction(int x);

static class Program
{
    public static bool All<T>(IEnumerable<T> sequence, Predicate<T> function)
    {
        foreach(var item in sequence)
            if (!function(item))
                return false;
        return true;
    }

    public static bool Any<T>(IEnumerable<T> sequence, Predicate<T> function)
    {
        foreach(var item in sequence)
            if (function(item))
                return true;
        return false;
    }

    public static bool Any<T>(IEnumerable<T> sequence)
    {
        return Any(sequence, (_) => true);
    }

    public static IEnumerable<(T1, T2)> Zip<T1, T2>(IEnumerable<T1> sequence1, IEnumerable<T2> sequence2)
    {
        IEnumerator<T1> enumerator1 = sequence1.GetEnumerator();
        IEnumerator<T2> enumerator2 = sequence2.GetEnumerator();

        while (enumerator1.MoveNext())
        {
            Debug.Assert(enumerator2.MoveNext());
            yield return (enumerator1.Current, enumerator2.Current);
        }
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

    public static void ForEach<T>(IEnumerable<T> sequence, Action<T> action)
    {
        foreach(var item in sequence)
            action(item);
    }

    public static int Count<T>(IEnumerable<T> sequence, Predicate<T> predicate)
    {
        int count = 0;
        foreach(var item in sequence)
            if (predicate(item))
                ++count;

        return count;
    }

    public static IEnumerable<T> Take<T>(IEnumerable<T> sequence, int n)
    {
        if (n < 0)
            throw new InvalidOperationException("n must be non-negative");

        var enumerator = sequence.GetEnumerator();
        for (int i = 0; i < n; i++)
            {
                if (enumerator.MoveNext())
                    yield return enumerator.Current;
                else
                    yield break;
            }
    }

    public static IEnumerable<int> UpToN(int maximum)
    {
        for (int i = 0; i <= maximum; i++)
            yield return i;
    }

    public static IEnumerable<int> UpTo10()
    {
        return UpToN(10);
    }

    public static IEnumerable<int> GetSmallNumbers()
    {
        yield return 1;
        yield return 6;
        yield return 8;
    }

    delegate int Myfunction(int x);

    public static bool IsOdd(int number)
    {
        return number % 2 == 0;
    }

    public static int Main(string[] args)
    {
        var numbers = new int[] { 1, 3, 99, 1001 };
        var strings = new string[] { "One", "Three", "NinetyNine", "ThousandAndOne", "Extra value" };

        Console.WriteLine(All(numbers, (x) => x % 2 == 1));

        Predicate<int> smallerThan10 = (x) => x < 10;
        Myfunction fn = Math.Abs;

        Console.WriteLine(Any(UpTo10(), smallerThan10));

        Console.WriteLine(All(UpToN(int.MaxValue), smallerThan10));

        Console.WriteLine("== zip output ==");
        foreach(var item in Zip(numbers, strings))
            Console.WriteLine($"{item.Item1}: {item.Item2}");

        Func<int, int, int> multiplyPair = (x, y) => x * y;

        Console.WriteLine(multiplyPair(3, 4));

        Console.WriteLine(Any(Filter(UpToN(int.MaxValue), (x) => x % 100 == 7)));
        Console.WriteLine(First(Filter(UpToN(int.MaxValue), (x) => x % 100 == 7)));

        ForEach(numbers, Console.Write);
        Console.WriteLine();

        Console.WriteLine("Complex expression:");
        Console.WriteLine(Count(Take(Filter(Filter(UpToN(1000000), (x) => x > 1000), (x) => x % 13 == 0), 10), IsOdd));

        /* Example that uses so called Extension Methods from IEnumerable<T> interface: */

        var exampleConfigFile = @"""
        ; this is sample config file that
        ; author: XYZ
        ; address = IP address

        name = My server
        address = 192.168.5.4
        key = asdflkasdkasjdlfka


        """;

        var parsedAddress = (exampleConfigFile
            .Split()
            .Where(line => !line.StartsWith(";"))
            .Where(line => !string.IsNullOrWhiteSpace(line))
            .Select(line => line.Split('='))
            .First(line => line[0] == "address")).Last();

        Console.WriteLine(parsedAddress);

        return 0;
    }
}

