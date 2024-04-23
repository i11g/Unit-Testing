using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "fox";

        // Act
        string result=Substring.RemoveOccurrences(input, toRemove);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "the";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "the";

        // Act
        string result = Substring.RemoveOccurrences(input, toRemove);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "dog";

        // Act
        string result = Substring.RemoveOccurrences(input, toRemove);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "The quick brown fox jumps over the lazy dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "";

        // Act
        string result = Substring.RemoveOccurrences(input, toRemove);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
