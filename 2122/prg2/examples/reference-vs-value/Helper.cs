
static class Helper
{
    public static void Add5(int value)
    {
        value += 5;
    }

    public static void Add5(ref int value)
    {
        value += 5;
    }

    public static void Add5Out(out int value)
    {
        value = 12345;
    }

    public static void AddToStringRef(ref string str)
    {
        str += "+pes";
    }

    public static void AddToString(string str)
    {
        str += "+pes";
    }

    public static void Update(List<int> list)
    {
        list.Add(100);
        list = new List<int>() { 4, 5, 6 };
    }

    public static void UpdateRef(ref List<int> list)
    {
        list.Add(100);
        list = new List<int>() { 4, 5, 6 };
    }

    public static void PrintArray(in int[] array, bool newLine = true)
    {
        Console.Write("[");
        foreach(var item in array)
            Console.Write($"{item}, ");
        Console.Write("]");

        if (newLine)
            Console.WriteLine();
    }

    public static void PrintArray(in int[][] arrays)
    {
        foreach (var array in arrays)
        {
            PrintArray(array, false);
            Console.Write(", ");
        }
        Console.WriteLine();
    }
}