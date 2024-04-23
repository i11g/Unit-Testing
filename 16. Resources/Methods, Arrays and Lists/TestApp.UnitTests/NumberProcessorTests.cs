using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        //// Arrange
        //List<int> input = new() { 2, 4, 6 };
        //List<double> expected = new() { 4, 16, 36 };

        //// Act
        //List<double> actual = NumberProcessor.ProcessNumbers(input);

        //// Assert
        //CollectionAssert.AreEqual(expected, actual);

        //Arrange
        List<int> numbers = new List<int>() { 2, 8, 16 };
        //Act
        List<double> result= NumberProcessor.ProcessNumbers(numbers);
        //Assert
        Assert.That(result, Is.EqualTo(new List<int>() { 4, 64,256 }));

    } 
    
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        //// Arrange 
        //List<int> oddNumbers=new List<int> { 9, 25, 49 };
        //List<double> expected = new List<double> { 3, 5, 7 };

        //// Act
        //List<double> result = NumberProcessor.ProcessNumbers(oddNumbers);

        //// Assert
        //CollectionAssert.AreEqual(expected, result);

        //Arrange
        List<int> numbers = new List<int>() { 9, 81, 25 };
        //Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);
        //Assert
        CollectionAssert.AreEqual(result, (new List<int>() { 3, 9, 5 }));

    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        //// Arrange
        //List<int> input = new() { 0 };
        //List<int> expected = new() { 0 };

        //// Act
        //List<double> result= NumberProcessor.ProcessNumbers(input);

        //// Assert
        //CollectionAssert.AreEqual(expected,result);

        //Arrange
        List<int> numbers = new List<int>() { 0 };
        //Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);
        //Assert
        CollectionAssert.AreEqual(result, (new List<int>() { 0 }));
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        ////Arrange
        //List<int> negativeNumbers = new List<int>() { -9, -49, -25 };

        ////Act&Assert
        //Assert.That(() => NumberProcessor.ProcessNumbers(negativeNumbers), Throws.ArgumentException);


        // Arrange
        List<int> n = new List<int>() { -5, -10,-30 };
            //Assert
        //Assert.Throws<ArgumentException>(() => NumberProcessor.ProcessNumbers(n));
        Assert.That(() => NumberProcessor.ProcessNumbers(n), Throws.ArgumentException);
     }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        ////Arrange
        //List<int> emptryArray=new List<int>();
        //List<int> expected=new List<int>();

        ////Act
        //List<double> result = NumberProcessor.ProcessNumbers(emptryArray);
        ////Assert
        //CollectionAssert.AreEqual(result,expected);

        //Arramge
        List<int> empty = new List<int>();
        //Act
        List<double> result = NumberProcessor.ProcessNumbers(empty);
        //Assert
        Assert.That(result, Is.Empty);

    }
}
