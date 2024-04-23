using NUnit.Framework;

using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text =" ";
        List<string> expected = new List<string>();

        // Act
        List<string> result=MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "absvdvd!!!";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

        [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text ="Single URL: http://www.example.com";
        List<string> expected = new List<string>(){"http://www.example.com"};

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        //Assert.AreEqual(result, expected);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Multiple URL's: http://www.example.com, http://www.google.com";
        List<string> expected = new List<string>() {"http://www.example.com", "http://www.google.com"};

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        //Assert.AreEqual(result, expected);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "URLs: \"http://dir.bg.com\" ";
        List<string> expected = new List<string>() { "http://dir.bg.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        //Assert.AreEqual(result, expected);
        Assert.That(result, Is.EqualTo(expected));
    }
}

