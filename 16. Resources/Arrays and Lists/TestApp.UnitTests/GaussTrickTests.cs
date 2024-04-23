using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        //// Arrange
        //List<int> emptyList = new();

        //// Act
        //List<int> result = GaussTrick.SumPairs(emptyList);

        //// Assert
        //CollectionAssert.AreEqual(emptyList, result);

        //Arrange
        List<int> empty = new List<int>() { };
        //Act
        List<int> result= GaussTrick.SumPairs(empty);
        //Assert
        CollectionAssert.AreEqual(empty, new List<int>() { });

    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        //// Arrange
        //List<int> singleElement= new List<int>() {1000};

        //// Act
        //List<int> result=GaussTrick.SumPairs(singleElement);

        //// Assert
        //CollectionAssert.AreEqual(singleElement, result);

        //Arrange
        List<int> singleElement = new List<int>() {42};
        //Act
        List<int> result = GaussTrick.SumPairs(singleElement);
        //Assert
        CollectionAssert.AreEqual(new List<int>() {42}, result);
    }

    
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        //// Arrange
        //List<int> evenCountElements= new List<int>() {4,8,16,20};
        //List<int> expectedResult = new List<int>() {24, 24};

        //// Act
        //List<int> result = GaussTrick.SumPairs(evenCountElements);

        //// Assert
        //CollectionAssert.AreEqual(result, expectedResult);

        //Arrange
        List<int> evenElements = new List<int>() { 42,24,10,5 };
        List<int> expected = new List<int>() { 47, 34 };
        //Act
        List<int> result = GaussTrick.SumPairs(evenElements);
        //Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        //// Arrange
        //List<int> evenCountElements = new List<int>() { 4, 8, 5, 16, 20 };
        //List<int> expectedResult = new List<int>() { 24, 24, 5};

        //// Act
        //List<int> result = GaussTrick.SumPairs(evenCountElements);

        //// Assert
        //CollectionAssert.AreEqual(result, expectedResult);

        //Arrange
        List<int> oddElements = new List<int>() { 42, 24,22, 10, 5 };
        List<int> expected = new List<int>() { 47, 34, 22 };
        //Act
        List<int> result = GaussTrick.SumPairs(oddElements);
        //Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
    // Arrange
    List<int> evenCountElements = new List<int>() {4, 8, 5, 10, 34, 54, 65, 76, 16, 20 };
    List<int> expectedResult = new List<int>() { 24, 24, 81, 75, 88 };

    // Act
    List<int> result = GaussTrick.SumPairs(evenCountElements);

    // Assert
    CollectionAssert.AreEqual(result, expectedResult);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
        
    {
        // Arrange
        List<int> evenCountElements = new List<int>() { 4, 8, 5, 10, 34, 1001, 54, 65, 76, 16, 20 };
        List<int> expectedResult = new List<int>() { 24, 24, 81, 75, 88, 1001 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountElements);

        // Assert
        CollectionAssert.AreEqual(result, expectedResult);
    }
}


