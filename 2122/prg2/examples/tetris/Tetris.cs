using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

struct Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point Clone()
    {
        return new Point(X, Y);
    }

     public int X, Y;
}

class TetrisShape
{
    public TetrisShape(Point[] points, ConsoleColor color)
    {
        Points = new(points);
        Color = color;
    }

    public int Width
    {
        get
        {
            var yValues = Points.Select(p => p.Y).OrderBy(p => p).ToList();
            return yValues.Max() - yValues.Min() + 1;
        }
    }

    public HashSet<Point> Points;
    public ConsoleColor Color;
}

class Tetris
{
    public const int WIDTH = 10;
    public const int HEIGHT = 20;

    const string WALL_CHAR = "\u2588";
    const string LEFT_PADDING = "    ";
    const ConsoleColor WALL_COLOR = ConsoleColor.DarkYellow;

    public readonly TetrisShape[] Shapes = {
        new TetrisShape(new Point[] { new(0, 0) }, ConsoleColor.DarkMagenta),
        new TetrisShape(new Point[] { new(0, 0), new(0, 1), new(1, 0), new(1, 1) }, ConsoleColor.DarkCyan),
        new TetrisShape(new Point[] { new(0, 0), new(0, 1), new (0, 2),
                                      new (1, 0), new(1, 1), new (1, 2),
                                      new (2, 0), new (2, 1), new (2, 2)}, ConsoleColor.DarkGreen),
    };

    public int Steps = 0;
    public int Score = 0;

    public Dictionary<Point, ConsoleColor> Points = new();

    public void Print()
    {
        // print some padding
        Console.WriteLine();
        Console.WriteLine($"{LEFT_PADDING}Steps: {Steps}");
        Console.WriteLine($"{LEFT_PADDING}Score: {Score}");
        Console.WriteLine($"{LEFT_PADDING}Dots: {Points.Count}");
        Console.WriteLine();

        for (int i = 0; i < HEIGHT; i++)
        {
            Console.Write(LEFT_PADDING);
            PrintString(WALL_CHAR, WALL_COLOR);
            for (int j = 0; j < WIDTH; j++)
            {
                Point key = new(j, i);
                if (Points.TryGetValue(key, out ConsoleColor color))
                    PrintString(WALL_CHAR, color);
                else
                    Console.Write(' ');
            }
            PrintString(WALL_CHAR, WALL_COLOR);
            Console.WriteLine($" {i}");
        }

        Console.Write(LEFT_PADDING);
        for (int j = 0; j < WIDTH + 2; j++)
            PrintString(WALL_CHAR, WALL_COLOR);
        Console.WriteLine();

        // ruler
        Console.Write(LEFT_PADDING + " ");
        for (int j = 0; j < WIDTH; j++)
            Console.Write(j % 10);
        Console.WriteLine();

        for (int i = 0; i < 2; i++)
            Console.WriteLine();
    }


    public void BurnLines()
    {
        for (int y = HEIGHT - 1; y >= 0;)
        {
            var levelPoints = Points.Keys.Where(x => x.Y == y).ToList();

            // burn the level
            if (levelPoints.Count == WIDTH)
            {
                // remove the points
                foreach(var point in levelPoints)
                    Points.Remove(point);

                // move all points down by one
                var newPoints = new Dictionary<Point, ConsoleColor>();
                foreach(var point in Points.Keys)
                    newPoints[new Point(point.X, point.Y + 1)] = Points[point];

                Points = newPoints;

                // update score
                Score += WIDTH;
            }
            else
                y--;
        }
    }

    public bool AddShape(TetrisShape shape, int x)
    {
        List<Point> points = shape.Points.Select(p => new Point(p.X + x, p.Y)).ToList();
        foreach(var point in points)
        {
            if (point.X > WIDTH || point.X < 0)
                throw new InvalidOperationException($"Shape X coordinate ({point.X}) out of range");
        };

        // game over
        if (HasCollision(points))
            return false;

        // let the shape fall down
        while (true)
        {
            var moved = points.Select(p => new Point(p.X, p.Y + 1)).ToList();
            if (HasCollision(moved))
                break;
            else
                points = moved;
        }

        foreach (var point in points)
            Points.Add(point, shape.Color);

        Steps++;
        return true;
    }

    public void AddShapeWithInteraction(TetrisShape shape, int x)
    {
        /*
        if (Steps != 0)
        {
            Console.WriteLine("Confirm by pressing a key (q for quit)...");
            var key = Console.ReadKey();
            if (key.KeyChar == 'q')
                Environment.Exit(1);
        }
        */
        Thread.Sleep(500);

        if (!AddShape(shape, x))
        {
            PrintString("=== GAME OVER! ===\n", ConsoleColor.Red);
            Environment.Exit(1);
        }
        else
            Console.Clear();

        BurnLines();
        Print();
    }

    private bool HasCollision(IEnumerable<Point> points)
    {
        foreach(var point in points)
        {
            if (point.Y >= HEIGHT)
                return true;
            
            if (Points.ContainsKey(point))
                return true;
        }

        return false;
    }

    private void PrintString(string message, ConsoleColor color)
    {
        var currentColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ForegroundColor = currentColor;
    }
}