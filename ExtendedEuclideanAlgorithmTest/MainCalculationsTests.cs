using ExponentcialCipher;

namespace ExtendedEuclideanAlgorithmTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateMethod()
    {
        Assert.That(ExtendedEuclideanAlgorithm.Calculate(29,2633), Is.EqualTo(2269));
    }
}