using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        //// Arrange
        //List<int>? nullList = null;

        //// Act & Assert
        ////Assert.Throws<ArgumentException>(() => {MaxNumber.FindMax(nullList); });
        //Assert.That(()=>MaxNumber.FindMax(nullList), Throws.ArgumentException);
        
        //Arrange
        List <int> empty = null;
        //Act&Assert
        Assert.That(()=> MaxNumber.FindMax(empty), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        //// Arrange
        //List<int> emptyList = new();

        //// Act & Assert
        //Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(emptyList);});
        //Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);

        //Arrange
        List<int> empty1 = new List<int>() { };
        //Act&Assert
        Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(empty1); });
            
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        ////Arrange
        //List<int> oneElement = new List<int>() { 42 };

        ////Act

        //int result=MaxNumber.FindMax(oneElement);

        ////Assert

        //Assert.That(result,Is.EqualTo(42));

        //Arrange
        List<int> one = new List<int>() { 170 };
        //Act
        int result = MaxNumber.FindMax(one);
        //Assert
        Assert.That(result,Is.EqualTo(170));

    }
    
    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        ////Arrange 
        //List<int> positiveIntegers=new List<int>() {4,6,100};
        ////Act
        //int result = MaxNumber.FindMax(positiveIntegers);
        ////Assert
        //Assert.That(result, Is.EqualTo(100));

        //Arrange
        List<int> positive = new List<int>() { 5, 10, 45 };
        //Act
        int max= MaxNumber.FindMax(positive);
        //Assert
        Assert.AreEqual(45,max);

    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        ////Arrange 
        //List<int> negativeIntegers = new List<int>() { - 4, - 6, -100, -2 };
        ////Act
        //int result = MaxNumber.FindMax(negativeIntegers);
        ////Assert
        //Assert.That(result, Is.EqualTo(-2));

        //Arrange
        List<int> negative = new List<int>() { -5, -10, };
        //Act
        int max= MaxNumber.FindMax(negative);
        //Assert
        Assert.AreEqual(-5, max);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        ////Arrange
        //List<int> mixedIntegers = new List<int> { 4, 6, 100, -5, -8, 1000 };
        ////Act
        //int result = MaxNumber.FindMax(mixedIntegers);
        ////Assert
        //Assert.That(result, Is.EqualTo(1000));

        //Arrange
        List<int> mix = new List<int>() { 5, 10, -9, 0, -18 };
        //Act
        int max= MaxNumber.FindMax(mix);
        //Assert
        Assert.That(max, Is.EqualTo(10));

    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        ////Arrange
        //List<int> mixedIntegers = new List<int> {1000, 4, 6, 6, 100, -5, -8, 1000,1100,1100 };
        ////Act
        //int result = MaxNumber.FindMax(mixedIntegers);
        ////Assert
        //Assert.That(result, Is.EqualTo(1100));

        //Arrange
        List<int> maxValues = new List<int>() { 10, 30, 50, 50, }; 
        //Act
        int max= MaxNumber.FindMax(maxValues);
        //Assert
        Assert.That(max,Is.EqualTo(50));
    }
}
