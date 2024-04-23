using NUnit.Framework;

using System;
using TestApp.Store;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp] 

    public void SetUp()
    {
        _article = new Article();
    }

    
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input =
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3, Content3, Author3"
        };

        // Act

        Article result=this._article.AddArticles(input);         

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        //Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
              new Article()
               {
                Author = "Pesho",
                Content ="new",
                Title="Burgas"

                },
              new Article()
              {
                  Author="Gosho",
                  Content="old",
                  Title="Sofia and Varna"
              }
            }
        };
        string expected = $"Burgas - new: Pesho{Environment.NewLine}Sofia and Varna - old: Gosho";
        
        //Acft
        string result = this._article.GetArticleList(inputArticle,"title");

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        //Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Pesho",
                    Content = "new",
                    Title = "Burgas"

                },
                new Article()
                {
                    Author = "Gosho",
                    Content = "old",
                    Title = "Sofia and Varna"
                }
            }
        };

        //Act
        string result = this._article.GetArticleList(inputArticle, "iD");

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}
