using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input=Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
        Assert.That(result,Is.Empty);
    }

    
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] single = new string[] { "abc" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(single);

        // Assert

        Assert.That(result,Is.EqualTo( "abc"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        //Arrange
        string[] input = { "Pleven", "Varna" };
        //Act
        string result= ReverseConcatenate.ReverseAndConcatenateStrings(input);
        //Assert
        Assert.That(result, Is.EqualTo("VarnaPleven"));

    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        //Arrange
        string[] input = null;
        //Act
        string result=ReverseConcatenate.ReverseAndConcatenateStrings(input);
        
        //Asert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        //Arrange
        string[] input = new [] {"Pleven Varna" };
        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        //Assert
        Assert.That(result, Is.EqualTo("Pleven Varna"));
        
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] input = new[] { "Pleven", "Varna", "Sofia", "Lovech" };
        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        //Assert.That
        Assert.That(result, Is.EqualTo("LovechSofiaVarnaPleven"));
    }
}
