using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        ////Arrange
        //char[] ch = null;
        ////Act&Assert
        //Assert.That(()=>Fake.RemoveStringNumbers(ch),Throws.ArgumentException);

        //Arrange
        char[] chars = null;
        //Act&Assert
        Assert.That(() => Fake.RemoveStringNumbers(chars), Throws.ArgumentException);

    }
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] charsWithNumbers = new char[] { '0', '1', 'c', 'b', 'c' };
        char[] expected = new char[] { 'c', 'b', 'c' };
        //Act
        char[] result = Fake.RemoveStringNumbers(charsWithNumbers);
        //Arrange
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] charsWithNumbers = new char[] { 'c', 'b', 'c' };
        char[] expected = new char[] { 'c', 'b', 'c' };
        //Act
        char[] result = Fake.RemoveStringNumbers(charsWithNumbers);
        //Arrange
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    { 
        //Arrange
        
        char[] emptyArray=Array.Empty<char>();

        //Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);
        //Assert
        Assert.That(result,Is.Empty);

    }
}
