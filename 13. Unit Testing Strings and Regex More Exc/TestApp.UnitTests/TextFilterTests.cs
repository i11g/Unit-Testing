using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = { };
        string text = "Sofia,Pleven";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWord = {"Sofia","Pleven" };
        string text = "Sofia,Pleven,Varna";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo("*****,******,Varna"));

    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = {" "};
        string text = "Sofia,Pleven,Varna";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWord = { "Sofia",  "Pleven" };
        string text = "Sofia,Pleven,Varna";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo("*****,******,Varna"));
    }
}
