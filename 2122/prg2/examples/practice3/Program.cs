using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        /* 1) testing square operations */
        var square = new Square(2, true);
        Console.WriteLine(square.Describe());
        square.Print();

        bool result = square.MultiplySize(0);
        Debug.Assert(!result);
        result = square.MultiplySize(2);
        Debug.Assert(result);
        Debug.Assert(square.Perimeter == 16);

        square.Transparent = false;
        Console.WriteLine();
        square.Print();
        Debug.Assert(square.Describe() == "Square[4x4]");

        Console.WriteLine();

        /* 2) testing circle operations */
        var circle = new Circle(5);
        circle.Print();
        result = circle.MultiplySize(-5);
        Debug.Assert(!result);
        result = circle.MultiplySize(2);
        Debug.Assert(result);
        Debug.Assert(circle.Surface > 78m && circle.Surface < 79m);

        Console.WriteLine();
        circle.Print();
        Console.WriteLine();

        /* 3) shapes in container */
        IShape[] shapes = new IShape[] { new Square(1), new Square(4), new Circle(5, false) };
        foreach (IShape shape in shapes)
        {
            shape.MultiplySize(2);
            Console.WriteLine(shape.Describe());
        }

#if false
        /* 4) play with Number class */
        Console.WriteLine("A play with Numbers:");

        var number = new Number(1) + new Number(234);
        Console.WriteLine(number);
        number *= 1;
        number = number * 3;
        Console.WriteLine(number);
        number = -number;
        Console.WriteLine(number);

        long intNumber = number;
        Debug.Assert(intNumber == 432143214321);
        var number2 = new Number(intNumber);
#endif
    }
}
