using NUnit.Framework;
using mylib;

namespace tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [TestCase(1)]
    [TestCase(100)]
    [TestCase(1000)]
    public void TestGetValue(int value)
    {
        Assert.That(Class1.GetValue() != value);
    }
}