using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        //// Arrange
        //int[] emptyArray = Array.Empty<int>();

        //// Act
        //string result = Reverse.ReverseArray(emptyArray);

        //// Assert
        //Assert.That(result, Is.EqualTo(string.Empty));

        //Arrange
        int[] empty = new int [] { };
        int[] empty1=Array.Empty<int> ();
        //Act
        string result = Reverse.ReverseArray(empty);
        //Assert
        Assert.That(result,Is.Empty);
       // Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        //    // Arrange
        //    int[] oneElementArray = new int[1] { 100 };

        //    // Act
        //    string result= Reverse.ReverseArray(oneElementArray);

        //    // Assert
        //    Assert.That(result, Is.EqualTo("100"));
        //}

        //Arrange
        int[] array = new int[] { 125 };
        //Act
        string result = Reverse.ReverseArray(array);
        //Assert
        Assert.AreEqual("125", result);
    }
    [Test]
    public void SecondTest_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] oneElementArray = new int[] { 42 };

        // Act
        string result = Reverse.ReverseArray(oneElementArray);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        ////Arrange
        //int[] multipleElementsArray= new int[] {100, 0, -42, 7, 8 };
        ////Act
        //string result = Reverse.ReverseArray(multipleElementsArray);
        ////Assert
        //Assert.That(result, Is.EqualTo("8 7 -42 0 100"));

        //Arrange
        int[] multiArray = new int[] { 3, 6, 8, 9, 0, -100 };
        //Act
        string reversed=Reverse.ReverseArray(multiArray);
        //Assert
        Assert.That(reversed, Is.EqualTo("-100 0 9 8 6 3"));

    }
}
