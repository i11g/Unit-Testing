using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;
using TestApp;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        //// Arrange
        //int[] emptyArray = Array.Empty<int>();

        //// Act & Assert

        ////Assert.Throws<ArgumentException>(() => { Average.CalculateAverage(emptyArray);});
        //Assert.That(()=>Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
        //Arrange
        int[] empty=Array.Empty<int>();
        //Act&Assert
        Assert.That(()=> Average.CalculateAverage(empty), Throws.ArgumentException);
    }

    
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        //// Arrange
        //int[] array = { 42 };

        //// Act
        //double result = Average.CalculateAverage(array);

        //// Assert
        //Assert.That(result, Is.EqualTo(42));

        //Arrange
        int[] oneElement=new int[] {15};
        //Act
        double result = Average.CalculateAverage(oneElement);
        //Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        ////Arrange
        //int[] newArray = new int[] { 3, 4, 6, 8 };
        ////Act
        //double result = Average.CalculateAverage(newArray);
        ////Assert
        //Assert.That(result, Is.EqualTo(5.25));

        //Arramge

        int[] array=new int[] {1,4,6,7};        
        //Act
        double result= Average.CalculateAverage(array);
        //Assert
        Assert.That(result, Is.EqualTo(4.50));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        ////Arrange
        //int[] newArray = new int[] { -3, -3, -3 };
        ////Act
        //double result = Average.CalculateAverage(newArray);
        ////Assert
        //Assert.AreEqual(result, - 3);

        //Arrange
        int[] negative = new int[] { -4, -8, 0, -9 };
        //Act
        double result = Average.CalculateAverage(negative);
        //Assert
        Assert.That(result, Is.EqualTo(-5.25));

    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange

        int[] mixedArray = new int[] { -5, 6, 9, 0, -32 };
        //Act
        double actual = Average.CalculateAverage(mixedArray);
        //Assert
        Assert.That(actual, Is.EqualTo(-4.4));

    }
}
