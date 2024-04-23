using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        //// Arrange
        //int[]? inputArray = null;

        //// Act + Assert
        //Assert.That(()=> Pattern.SortInPattern(inputArray),Throws.ArgumentException);

        //Arrange
        int[] arr = null;
        //Act&Assert
        Assert.That(() => Pattern.SortInPattern(arr), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        ////Arrange
        //int[] num=new int[] { 1, 1, 2, 3,5 };
        //int[] expectrd = new int[] { 1, 5, 2, 3 };
        ////Act
        //int[] result = Pattern.SortInPattern(num);
        ////Assert
        //CollectionAssert.AreEqual(expectrd, result);

        //Arrange
        int[] arr = new int[] {1, 2, 2, 4 ,5 ,6, 78, 9 };
        int[] expected = new int[] { 1, 78 ,2, 9, 4, 6, 5 };
        //Act
        int[] result = Pattern.SortInPattern(arr);
        //Assert
        CollectionAssert.AreEqual(expected, result);
   }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        ////Arrange
        //int[] emptyArray=Array.Empty<int>();
        ////Act
        //int[] result=Pattern.SortInPattern(emptyArray);
        ////Assert
        //Assert.That(result, Is.Empty);
        
        //Arrange
        int[] empty=Array.Empty<int>();
        //Act
        int[] result = Pattern.SortInPattern(empty);
        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        ////Arrange
        //int[] singleArray = new int[] { 5 };
        //int[] expected = new int[] { 5 };
        ////Act
        //int[] result = Pattern.SortInPattern(singleArray);
        ////Assert
        //CollectionAssert.AreEqual(expected, result);

        //Arrange
        int[] single = new int[] { 56 };
        //Act
        int[] result= Pattern.SortInPattern(single);
        //Asert
        Assert.That(result, Is.EqualTo(new int[] { 56 }));
    }
}
