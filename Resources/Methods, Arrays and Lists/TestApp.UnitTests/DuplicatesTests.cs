using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        //// Arrange
        //int[] emptryArray = new int[] { };
        ////Act
        //int[] result = Duplicates.RemoveDuplicates(emptryArray);
        ////Assertt
        //Assert.That(result, Is.Empty);

        //Arrange
        int[] numbers=Array.Empty<int>();
        //Act
        int[] result= Duplicates.RemoveDuplicates(numbers);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        ////Arrange
        //int[] noDuplicates=new int[] {1,2,3,4,5};
        //int[] excpected= new int[] { 1, 2, 3, 4, 5 };
        ////Act
        //int[] result= Duplicates.RemoveDuplicates(noDuplicates);
        ////Assert
        //CollectionAssert.AreEqual(excpected, result);

        //Arrange
        int[] noDuplicates = new int[] { 1, 2, 3, 5, 9, 0 };
        int[] expected = new int[] { 1, 2, 3, 5, 9, 0 };

        //Act
        int[] result= Duplicates.RemoveDuplicates(noDuplicates);
        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        //Arrange
        int[] someDuplicates = new int[] { 1, 2, 2, 3, 4, 5, 5 };
        int[] excpected = new int[] { 1, 2, 3, 4, 5 };
        //Act
        int[] result = Duplicates.RemoveDuplicates(someDuplicates);
        //Assert
        CollectionAssert.AreEqual(excpected, result);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        //Arrange
        int[] someDuplicates = new int[] { 5,5,5,5,5,5,5  };
        int[] excpected = new int[] { 5 };
        //Act
        int[] result = Duplicates.RemoveDuplicates(someDuplicates);
        //Assert
        CollectionAssert.AreEqual(excpected, result);
    }
}
