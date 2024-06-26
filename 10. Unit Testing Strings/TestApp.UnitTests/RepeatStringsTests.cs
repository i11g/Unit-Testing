using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
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
        string[] input = { "Ua" };
        //Act
        string result=RepeatStrings.Repeat(input);
        //Assert
        Assert.That(result, Is.EqualTo("UaUa"));

    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        //Arrange
        string[] input = { "Sofia", "Pleven" };
        //Act 
        string resut=RepeatStrings.Repeat(input);
        //Assert
        Assert.That(resut, Is.EqualTo("SofiaSofiaSofiaSofiaSofiaPlevenPlevenPlevenPlevenPlevenPleven"));
    }
}
