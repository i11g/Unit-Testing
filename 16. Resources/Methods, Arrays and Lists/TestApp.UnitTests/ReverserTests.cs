using NUnit.Framework;

using System;
using System.Runtime.Serialization;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        ////Arrange
        //string[] emptyArray = Array.Empty<string>();
        ////Act
        //string[] result = Reverser.ReverseStrings(emptyArray);
        ////Assert
        //Assert.That(result, Is.Empty);

        //Arrange
        string[] arr=Array.Empty<string>();
        //Act
        string[] result= Reverser.ReverseStrings(arr);
        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        //// Arrange
        //string[] singleString = new string[] { "abc" };
        //string[] expected=new string[] { "cba" };
        ////Act
        //string[] result= Reverser.ReverseStrings(singleString);
        ////Assert
        //CollectionAssert.AreEqual(expected,result);


        //Arrange
        string[] single = new string[] { "adbs" };
        string[] expected = new string[] { "sbda" };
        //Act
        string[] rsresult= Reverser.ReverseStrings(single);
        //Assert
        Assert.That (rsresult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        ////Arrange
        //string[] multipleArrays = new string[] { "abc", "dca", "tui" };
        //string[] expected = new string[] { "cba", "acd", "iut" };
        ////Act
        //string [] result= Reverser.ReverseStrings(multipleArrays);
        ////Assert
        //CollectionAssert.AreEqual(expected, result);

        //Arrange
        string[] multiple = new string[] { "abc", "iava", "ytre" };
        string[] expected = new string[] { "cba", "avai", "erty" };
        //Act
        string[] result= Reverser.ReverseStrings(multiple);
        //Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        ////Arrange
        //string[] specialCharters = new string[] { "abc!", "DCA%", "Iavc&%" };
        //string[] expected = new string[] { "!cba", "%ACD", "%&cvaI" }; 
        ////Act
        //string[] result= Reverser.ReverseStrings(specialCharters);
        ////Assert
        //CollectionAssert.AreEqual(expected, result);

        //Arrange
        string[] multiple = new string[] { "Abc&%", "i#8ava", "ytre" };
        string[] expected = new string[] { "%&cbA", "ava8#i", "erty" };
        //Act
        string[] result = Reverser.ReverseStrings(multiple);
        //Assert
        CollectionAssert.AreEqual(expected, result);

    }
}
