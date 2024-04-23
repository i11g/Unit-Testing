using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    //[TestCase(new int[]  { 5 }, "")]
    //[TestCase(new int[] { }, "")]
    //[TestCase(new int [] {-2, 3,5,-7,8,9,0,5}, "8 -9 13 9")]
    //[TestCase(new int[] {1,2,3,4},"3 7")]

    [TestCase(new int [] {1, 2,3,4,5,6,7,8}, "5 5 13 13")]
    [TestCase(new int[] {}, "")]
    [TestCase(new int[] {3}, "")]
    [TestCase(new int[] {-1,-3,-5,6,7,8,0,9}, "-8 5 16 8")]
    [TestCase(new int[] { 1, 2, 3, 4 },"3 7")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        ////Arrange
        ////Act
        //string result=FoldSum.FoldArray(arr);
        ////Arrange
        //Assert.AreEqual(expected, result); 

        //Arrange
        //Act
        string result= FoldSum.FoldArray(arr);
        //Assert
        Assert.AreEqual(expected, result);



    }
}
