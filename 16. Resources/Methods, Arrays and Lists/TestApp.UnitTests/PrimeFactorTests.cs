using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        //    //Arrange
        //    int num = 1;
        //    //Act&Assert
        //    Assert.That(() => PrimeFactor.FindLargestPrimeFactor(num),Throws.ArgumentException);        
        //}
        //Arrange
        long num = 1;
        //Act&Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(num), Throws.ArgumentException);
    }
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //// Assert
        //long num = 168;
        ////Act
        //long prime = PrimeFactor.FindLargestPrimeFactor(num);
        ////Assert
        //Assert.That(prime, Is.EqualTo(7));

        //Arrange
        long num = 1121;
        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(num);
        //Assert
        Assert.That(result, Is.EqualTo(59));

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //// Assert
        //long num = 999999999;

        ////Act
        //long prime = PrimeFactor.FindLargestPrimeFactor(num);
        ////Assert
        //Assert.That(prime, Is.EqualTo(333667));

        //Arrage
        long number = 78797879797;
        //Act
        long result= PrimeFactor.FindLargestPrimeFactor(number);
        //Assert
        Assert.That(result, Is.EqualTo(308263));
    }
}
