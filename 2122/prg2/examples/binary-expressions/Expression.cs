// Taken from:
// http://www.ms.mff.cuni.cz/~topfermi/vyuka/2122/NPRG031/05/expressions/Program.cs

using System;
using System.Globalization;

namespace Expression
{
   class Expression
    {
        abstract class Node
        {
            public abstract double Evaluate();

            public virtual string Print()
            {
                return Evaluate().ToString(CultureInfo.InvariantCulture);
            }
        }

        sealed class ConstNode : Node
        {
            private readonly double value;

            public ConstNode(double value)
            {
                this.value = value;
            }

            public override double Evaluate() => value;
        }

        abstract class BinaryOperatorNode : Node
        {
            private Node left, right;

            public BinaryOperatorNode(Node left, Node right)
            {
                this.left = left;
                this.right = right;
            }

            public override double Evaluate()
            {
                double leftValue = left.Evaluate();
                double rightValue = right.Evaluate();
                return Operation(leftValue, rightValue);
            }

            protected abstract double Operation(double leftValue, double rightValue);

            public override string Print()
            {
                return $"({left.Print()}{Operator}{right.Print()})";
                //return "(" + left.Print() + Operator + right.Print() + ")";
            }

            protected abstract string Operator { get; }
        }

        sealed class Addition : BinaryOperatorNode
        {
            public Addition(Node left, Node right) : base(left, right) { }

            protected override string Operator => "+";

            protected override double Operation(double leftValue, double rightValue)
            {
                return leftValue + rightValue;
            }
        }

        sealed class Multiplication : BinaryOperatorNode
        {
            public Multiplication(Node left, Node right) : base(left, right) { }

            protected override string Operator => "*";

            protected override double Operation(double leftValue, double rightValue)
            {
                return leftValue * rightValue;
            }
        }
        sealed class Subtraction : BinaryOperatorNode
        {
            public Subtraction(Node left, Node right) : base(left, right) { }

            protected override string Operator => "-";

            protected override double Operation(double leftValue, double rightValue)
            {
                return leftValue - rightValue;
            }
        }

        sealed class Division : BinaryOperatorNode
        {
            public Division(Node left, Node right) : base(left, right) { }

            protected override string Operator => "/";

            protected override double Operation(double leftValue, double rightValue)
            {
                return leftValue / rightValue;
            }
        }

        private readonly Node root;

        public double Evaluate() => root.Evaluate();
        public string Print() => root.Print();

        private Expression(Node root)
        {
            this.root = root;
        }

        public static Expression Example => new(
            new Addition(
                new ConstNode(5),
                new Multiplication(
                    new Addition(
                        new ConstNode(6),
                        new ConstNode(7)
                    ),
                    new ConstNode(4)
                )
            )
        );

        public static Expression FromPostfix(string postfix)
        {
            var tokens = postfix.Split();

            var nodeStack = new Stack<Node>();

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double value))
                    nodeStack.Push(new ConstNode(value));
                else
                {
                    Node right = nodeStack.Pop();
                    Node left = nodeStack.Pop();
                    nodeStack.Push(token switch
                    {
                        "+" => new Addition(left, right),
                        "*" => new Multiplication(left, right),
                        "-" => new Subtraction(left, right),
                        "/" => new Division(left, right),
                        _ => throw new NotImplementedException(), // TODO: exception type
                    });
                }
            }

            // TODO: check that stack has exactly one item
            return new Expression(nodeStack.Pop());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Expression.Example.Evaluate());
            Console.WriteLine(Expression.Example.Print());

            Console.WriteLine(Expression.FromPostfix("5 6 7 + 4 * +").Print());
        }
    }
}