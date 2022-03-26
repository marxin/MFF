class Line: IComparable
{
    public Line(int width, string color)
    {
        Width = width;
        Color = color;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;

        return this.CompareTo(obj) == 0;
    }

    public override string ToString()
    {
        return $"Line({Width}, {Color})";
    }

    public int CompareTo(object obj)
    {
        var other = obj as Line;
        if (other is null)
            return -1;

        if (Width == 0 && other.Width == 0)
            return 0;

        return Width == other.Width ? Color.CompareTo(other.Color) : Width.CompareTo(other.Width);
    }

    public static bool operator==(Line a, Line b)
    {
        return a.Equals(b);
    }

    public static bool operator<(Line a, Line b)
    {
        return a.CompareTo(b) < 0;
    }

    public static bool operator>(Line a, Line b)
    {
        return a.CompareTo(b) > 0;
    }

    public static bool operator !=(Line a, Line b) => !(a == b);

    int Width;
    string Color;

    public override int GetHashCode()
    {
        return HashCode.Combine(Width, Color);
    }
}