using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        ////Arrange
        //string excpetion=null;
        ////Act&Assert
        //Assert.That(()=> ExtractFile.GetFile(excpetion),Throws.ArgumentNullException);

        //Arrange
        string path = null;
        //Act&Assert
        Assert.That(()=> ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        ////Arrange
        //string excpetion = string.Empty;
        ////Act&Assert
        //Assert.That(() => ExtractFile.GetFile(excpetion), Throws.ArgumentNullException);

        //Arrange
        string empty = "";
        //Act&Assert
        Assert.That(() => ExtractFile.GetFile(empty), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        ////Arrange
        //string valid = "validFile.doc";
        ////Act
        //string result = ExtractFile.GetFile(valid);
        ////Assert
        //Assert.AreEqual(result, "File name: validFile\nFile extension: doc");

        //Arrange
        string valid = "C:\\Users\\text.doc";
        string expected = "File name: text\nFile extension: doc";
        //Act
        string result = ExtractFile.GetFile(valid);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        ////Arrange
        //string valid = "validFile";
        ////Act
        //string result = ExtractFile.GetFile(valid);
        ////Assert
        //Assert.AreEqual(result, "File name: validFile");

        //Arrange
        string valid = "C:\\Users\\text";
        string expected = "File name: text";
        //Act
        string result = ExtractFile.GetFile(valid);
        //Assert
        Assert.AreEqual(expected,result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        ////Arrange
        //string valid = "validFile%&#.doc";
        ////Act
        //string result = ExtractFile.GetFile(valid);
        ////Assert
        //Assert.AreEqual(result, "File name: validFile%&#\nFile extension: doc");

        //Arrange
        string valid = "C:\\Users\\text@%*.doc";
        string expected = "File name: text@%*\nFile extension: doc";
        //Act
        string result = ExtractFile.GetFile(valid);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
