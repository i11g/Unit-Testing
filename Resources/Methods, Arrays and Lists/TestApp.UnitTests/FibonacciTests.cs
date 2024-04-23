using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        ////Arrenge
        //int num = -5;
        ////Act&Assert
        //Assert.That(()=> Fibonacci.CalculateFibonacci(num), Throws.ArgumentException);

        //Arrange
        int num = -5;
        //Act&Assert
        Assert.That(()=> Fibonacci.CalculateFibonacci(num), Throws.ArgumentException);

        
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        ////Arrange
        //int num = 0;
        ////Act
        //int result= Fibonacci.CalculateFibonacci(num);
        ////Assert
        ////Assert.That=(result,Is.EqualTo(num));

        //Arrange
        int num = 0;
        //Act
        int result = Fibonacci.CalculateFibonacci(num);
        //Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrenge
        int num = 8;
        //Act
        int result = Fibonacci.CalculateFibonacci(num);
        //Act
        Assert.That(result, Is.EqualTo(21));
    }
}