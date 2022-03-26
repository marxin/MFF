using System;

class Square : IShape
{
    private int x;
    bool transparent;

    public Square(int x, bool transparent = false)
    {
        this.x = x;
        this.transparent = transparent;
    }

    public decimal Surface => this.x * this.x;

    public decimal Perimeter { get => 4 * this.x; }

    public bool Transparent
    {
        get
        {
            return transparent;
        }

        set
        {
            this.transparent = value;
        }
    }

    public string Describe()
    {
        return string.Format("Square[{0}x{0}]", x);
    }

    public bool MultiplySize(int multiplier)
    {
        if (multiplier <= 0)
            return false;
        else
        {
            x *= multiplier;
            return true;
        }
    }

    public void Print()
    {
        for (int i = 0; i < x; i++)
            Console.WriteLine(new string(transparent ? '.' : '#', x));
    }
}

class Circle : IShape
{
    int diameter;
    bool transparent;

    public Circle(int diameter, bool transparent = false)
    {
        this.diameter = diameter;
        this.transparent = transparent;
    }

    public decimal Surface => (decimal)Math.PI * (diameter / 2) * (diameter / 2);

    public decimal Perimeter => (decimal)Math.PI * diameter;

    public bool Transparent { get => transparent; set => transparent = value; }

    public string Describe() => string.Format("Circle[{0}]", diameter);

    public bool MultiplySize(int multiplier)
    {
         if (multiplier <= 0)
            return false;
        else
        {
            diameter *= multiplier;
            return true;
        }
    }

    public void Print()
    {
        Console.WriteLine(new string(transparent ? '.' : 'o', diameter));
    }
}

class MyTestShape : IShape
{
    public decimal Surface => throw new NotImplementedException();

    public decimal Perimeter => throw new NotImplementedException();

    public bool Transparent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string Describe()
    {
        throw new NotImplementedException();
    }

    public bool MultiplySize(int multiplier)
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}