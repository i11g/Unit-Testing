using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //    //Arrange
        //    int[] array= null;
        //    //Act&Assert
        //    Assert.That(()=> LongestIncreasingSubsequence.GetLis(array),Throws.ArgumentNullException);
        //}

        //Arrange
        int[] nula = null;
        //Act&Assert
        Assert.That(()=> LongestIncreasingSubsequence.GetLis(nula), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // //Arrange
        //int[] array=Array.Empty<int>();
        ////Act
        //string result = LongestIncreasingSubsequence.GetLis(array);
        ////Assert
        //Assert.That(result, Is.Empty);

        //Arrange
        int[] empty = Array.Empty<int>();
        //Act
        string result = LongestIncreasingSubsequence.GetLis(empty);
        //Assert
        Assert.That(result,Is.Empty);

    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        ////Arrange
        //int[] array = new int[] {8};
        ////Act
        //string result = LongestIncreasingSubsequence.GetLis(array);
        ////Assert
        //Assert.That(result, Is.EqualTo("8"));
        //Arrange
        int[] single = new int[] {42};
        //Act
        string result = LongestIncreasingSubsequence.GetLis(single);
        //Assert
        Assert.That(result, Is.EqualTo("42"));

    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        ////Arrange
        //int[] array = new int[] {1,2,3,4,1,8,2,3};
        ////Act
        //string result = LongestIncreasingSubsequence.GetLis(array);
        ////Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 8"));

        //Arrange
        int[] multi = new int[] { 42,44,0,2,4,6,8,9};
        //Act
        string result = LongestIncreasingSubsequence.GetLis(multi);
        //Assert
        CollectionAssert.AreEqual(result, "0 2 4 6 8 9");
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Act
        string result = LongestIncreasingSubsequence.GetLis(array);
        //Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5 6 7 8"));
    }
}
