using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        //// Arrange
        //int[] emptyArray = Array.Empty<int>();

        //// Act
        //int result = EvenOddSubtraction.FindDifference(emptyArray);

        //// Assert
        //Assert.That(result, Is.EqualTo(0));

        //Arrange
        int[] array=Array.Empty<int>();
        //Act
        int result= EvenOddSubtraction.FindDifference(array);
        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        //// Arrange
        //int[] evenArray = new int [] {10,10}; 

        //// Act
        //int result= EvenOddSubtraction.FindDifference(evenArray);

        //// Assert
        //Assert.That(result, Is.EqualTo(20)); 

        //Arrange
        int[] even = new int[] { 2, 2, 4, 4};
        //Act
        int result = EvenOddSubtraction.FindDifference(even);
        //Assert
        Assert.That(result,Is.EqualTo(12));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnOddSum()
    {
        ////Arrange
        //int[] oddNumbersArray = { 3, 9, 11, 23 };
        ////Act
        //int result = EvenOddSubtraction.FindDifference(oddNumbersArray);

        ////Assert
        //Assert.AreEqual(result, 46);

        //Arrange
        int[] odd=new int[] { 1, 1,3, 5};
        //Act
        int result = EvenOddSubtraction.FindDifference(odd);
        //Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        ////Arrange
        //int[] mixedNumbersArray = new int[] { 0, 5, 6, 10, 7, 18, 28 };
        ////  Act 
        //int result = EvenOddSubtraction.FindDifference(mixedNumbersArray);
        ////Assert 
        //Assert.That(result, Is.EqualTo(50));

        //Arrange
        int[] odd = new int[] { 1, 1, 4, 5,10,8,7 };
        //Act
        int result = EvenOddSubtraction.FindDifference(odd);
        //Assert
        Assert.That(result, Is.EqualTo(8));


    }
}
