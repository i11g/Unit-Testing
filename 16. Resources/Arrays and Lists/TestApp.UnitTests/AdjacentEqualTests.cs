using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        //// Arrange
        //List<int>? nullList = null;

        //// Act & Assert
        //Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);

        //Arrange
        List<int> numbers = null;
        //Act&Asseert
        Assert.That(()=> AdjacentEqual.Sum(numbers), Throws.ArgumentException);
    }

  
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        //// Arrange
        //List<int> emptyList = new List <int> ();

        //// Act
        //string result = "";
        //// Assert
        //Assert.That(result,Is.EqualTo(emptyList));

        //Arrange
        List<int> empty=new List<int>();
        //Act
        string result = AdjacentEqual.Sum(empty);
        //Arrange
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        //// Arrange
        //List<int> noAdjacentEqualNumbers = new List<int>() { 1, 2, 3, 4, 5 };

        //// Act
        //string result = AdjacentEqual.Sum(noAdjacentEqualNumbers);

        //// Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));

        //Arrange
        List<int> numbers = new List<int>() { 1, 2, 5, 6, 8 };
        string expected = "1 2 5 6 8";
        //Act
        string result = AdjacentEqual.Sum(numbers);
        //Assert
        Assert.That(result,Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // //Arrange
        // List<int> summedList = new List<int>() { 1, 1, 3, 4, 4, 9 };


        // //Act
        // string result=AdjacentEqual.Sum(summedList);

        // //Assert
        //Assert.AreEqual(result, "2 3 8 9");

        //Arrange
        List<int> numbers = new List<int>() { 2, 2, 6, 6, 8 };
        string expected = "4 12 8";
        //Act
        string result = AdjacentEqual.Sum(numbers);
        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        ////Arrange
        //List<int> summedList = new List<int>() { 1, 1, 2, 4, 8 };

        ////Act
        //string result = AdjacentEqual.Sum(summedList);

        ////Assert
        //Assert.That(result, Is.EqualTo("16"));
        //Arrange
        List<int> numbers = new List<int>() { 2, 2, 2, 2, 2 };
        string expected = "8 2";
        //Act
        string result = AdjacentEqual.Sum(numbers);
        //Assert
        CollectionAssert.AreEqual(result, expected);

    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        ////Arrange
        //List<int> adjacentEqualAtgBeging=new List<int>() { 1, 1, 3, 4, 8 };

        ////Act
        //string result = AdjacentEqual.Sum(adjacentEqualAtgBeging);
        ////Assert
        //CollectionAssert.AreEqual(result, "2 3 4 8");

        List<int> numbers = new List<int>() { 2, 2, 3, 4, 2 };
       string expected = "4 3 4 2";
        //Act
        string result = AdjacentEqual.Sum(numbers);
        //Assert
        CollectionAssert.AreEqual(result, expected);

    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        //Arrange
        List<int> adjacentEqualAtEnd = new List<int>() { 1, 2, 3, 4, 5, 8,8 };
        
        //Act
        string result = AdjacentEqual.Sum(adjacentEqualAtEnd);
        //Assert
        CollectionAssert.AreEqual(result, "1 2 3 4 5 16");
    }


    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        //Arrange
        List<int> adjacentIntheMiddle = new List<int>() { 1, 2, 3, 3, 4, 5, 16 };
       
        //Act
        string result = AdjacentEqual.Sum(adjacentIntheMiddle);

        //Assert
        CollectionAssert.AreEqual(result, "1 2 6 4 5 16");
    }
}
