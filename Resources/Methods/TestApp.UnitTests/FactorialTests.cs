using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        ////Arrange 
        //int input = 0;

        ////Act
        //int result = Factorial.CalculateFactorial(input);
        ////Assert
        //Assert.That(result, Is.EqualTo(1));

        //Arrange
        int number = 0;
        //Act
        int result= Factorial.CalculateFactorial(number);
        //Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    { 
        //    //Arrange
        //    int input = 5;
        //    //Act
        //    int result = Factorial.CalculateFactorial(input);
        //    //Assert
        //    Assert.AreEqual(120, result);
        //}

        //Arrange
        int number = 5;
        //Act
        int result = Factorial.CalculateFactorial(number);
        //Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test] 
    public void CalculateFactorial_WhenInputIsNegative_ThrowsExeption()

    {    //Arrange
        //    int input = -5;
        //    //Act + Assert      
            //Assert.Throws <ArgumentOutOfRangeException> (() => { Factorial.CalculateFactorial(input); });

        //Arrange
        int number =-5;
        //Act&Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(number); });

      }
    
}
