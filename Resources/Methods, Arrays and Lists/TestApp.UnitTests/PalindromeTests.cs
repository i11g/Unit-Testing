using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        //// Arrange
        //List<string> palindrome = new List<string>() {"aha", "ara" };

        //// Act
        //bool actual =Palindrome.IsPalindrome(palindrome);

        //// Assert
        //Assert.That(actual,Is.True);

        //Arrange
        List<string> words = new List<string>() { "aha", "bob" };
        //Act
        bool result= Palindrome.IsPalindrome(words);
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        //    // Arrange
        //    List<string> words = new();

        //    // Act
        //    bool result= Palindrome.IsPalindrome(words);

        //    // Assert
        //    Assert.That(result,Is.True);
        //}

        //Arrange
        List<string> words = new List<string>() {};
        //Act
        bool result = Palindrome.IsPalindrome(words);
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        //Arrange
        List<string> singleWord = new List<string>() { "aha" };
        
        //Act
        bool result = Palindrome.IsPalindrome(singleWord);
        //Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        ////Arrange
        //List<string> singleWord = new List<string>() { "ahahhhaaa" };

        ////Act
        //bool result = Palindrome.IsPalindrome(singleWord);
        ////Assert
        //Assert.IsFalse(result);

        //Arrange
        List<string> eword= new List<string>() { "hhghhgha" };
        //Act
        bool result = Palindrome.IsPalindrome(eword);
        //Asert
        Assert.IsFalse(result);

    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        //Arrange
        List<string> singleWord = new List<string>() { "aHa" };

        //Act
        bool result = Palindrome.IsPalindrome(singleWord);

        //Assert
        Assert.IsTrue(result);
    }
}
