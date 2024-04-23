using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { " teo" };
        string text = "Sofis";

        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = { "teo" };
        string text = "Sofis teo";
        string expected = "Sofis ***";

        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Sofis teo";
        string expected = "Sofis teo";
        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { " teo"  };
        string text = "Sofis teo";
        string expected = "Sofis****";

        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
