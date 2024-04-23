using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        //Arrange
        string[] single = new string[] { "b" };
        //Act
        string result= RepeatStrings.Repeat(single);
        //Assert
        Assert.That(result, Is.EqualTo("b"));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        //Arrange
        string[] multipleStrings = new[] { "abc","njh" };  
        //Act
        string result= RepeatStrings.Repeat(multipleStrings);
        //Act
        Assert.That(result,Is.EqualTo("abcabcabcnjhnjhnjh"));
    }
}
