long Fib(long n)
{
    if (n <= 2)
        return 1;
    else
        return Fib(n - 1) + Fib(n - 2);
}

long FibMemorize(long n, Dictionary<long, long> memo)
{
    if (n <= 2)
        return 1;

    if (memo.ContainsKey(n))
        return memo[n];

    long fib = FibMemorize(n - 1, memo) + FibMemorize(n - 2, memo);
    memo[n] = fib;
    return fib;
}

long GridTravelerTabular(long m, long n)
{
    long[,] values = new long[m + 1, n + 1];
    values[1, 1] = 1;

    for (long i = 1; i < n + 1; i++)
        for (long j = 1; j < m + 1; j++)
            values[j, i] += values[j - 1, i] + values[j, i - 1];

    Console.WriteLine($"== GridTraveler({m}x{n}) ==", m, n);
    for (long i = 0; i < n + 1; i++)
    {
        for (long j = 0; j < m + 1; j++)
            Console.Write("{0} ", values[j, i]);
        Console.WriteLine();
    }

    return values[m, n];
}

bool CanSum(int sum, in int[] values)
{
    if (sum == 0)
        return true;
    else if (sum < 0)
        return false;

    foreach (int value in values)
    {
        int remainder = sum - value;
        if (CanSum(remainder, in values))
            return true;
    }

    return false;
}

int n = 50;
long fib = FibMemorize(50, new Dictionary<long, long>());
Console.WriteLine($"fib({n})={fib}");

Console.WriteLine();

(int m, int n) sizes = (6, 4);
long result = GridTravelerTabular(sizes.m, sizes.n);
Console.WriteLine($"GridTraveler({sizes.m}x{sizes.n})={result}");

Console.WriteLine();

Console.WriteLine(CanSum(10, new int[] { 7, 4 }));
Console.WriteLine(CanSum(100, new int[] { 7, 3 }));

var values = new int[] { 2, 4, 6 };
/* Extend an array */
var values2 = values.Append(555).ToArray();

/* Easy way of printing the values. */
Console.WriteLine(string.Join(' ',values.Select(x => x.ToString())));
Console.WriteLine(string.Join(' ',values2.Select(x => x.ToString())));