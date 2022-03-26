using System;

class Number
{
    string value;

    public string Value => value;

    public Number(string value="")
    {
        this.value = value;
    }

    public Number(long value): this(value.ToString())
    {
    }

    public override string ToString()
    {
        return string.Format("Number({0})", Value);
    }

    public static Number operator+(Number a, Number b)
    {
        return new Number(a.Value + b.Value);
    }

    public static Number operator-(Number a)
    {
        char[] values = a.Value.ToCharArray();
        Array.Reverse(values);
        return new Number(new string(values));
    }

    public static Number operator*(Number a, int times)
    {
        string v = string.Empty;
        for (int i = 0; i < times;i++)
            v += a.Value;
        return new Number(v);
    }

    public static implicit operator long(Number v)
    {
        return long.Parse(v.Value);
    }
}

namespace HideMe
{
    class Number
    {
        public Number(string value = "")
        {
        }

        public Number(long value)
        {
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public static Number operator +(Number a, Number b)
        {
            throw new NotImplementedException();
        }

        public static Number operator -(Number a)
        {
            throw new NotImplementedException();
        }

        public static Number operator *(Number a, int times)
        {
            throw new NotImplementedException();
        }

        public static implicit operator long(Number v)
        {
            throw new NotImplementedException();
        }
    }
}