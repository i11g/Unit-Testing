using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        //// Arrange
        //int input = 0;

        //// Act
        //string result = Triangle.PrintTriangle(input);

        //// Assert
        //Assert.AreEqual("",result);


        //Arrange
        int size = 0;
        //Act
        string result= Triangle.PrintTriangle(size);
        //Assert
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        ////Arrange
        //int input = 3;

        //string expectedOutput = "1"+ 
        //    "\r\n"+
        //    "1 2\r\n"+
        //    "1 2 3" +
        //    "\r\n"+
        //    "1 2"+
        //    "\r\n"+
        //    "1";

        ////Act
        //string result = Triangle.PrintTriangle(input);

        ////Assert
        //Assert.AreEqual(expectedOutput, Triangle.PrintTriangle(input));

        //Arrange 5

        int size = 4;
        string expected="1"+"\r\n"+"1 2\r\n"+"1 2 3\r\n"+ "1 2 3 4\r\n"+"1 2 3\r\n" + "1 2\r\n" + "1";
        //Act
        string result= Triangle.PrintTriangle(size);
        //Assert
        Assert.That(result,Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        //Arrage
        int input = 5;

        string expextedresult = "1"+"\r\n"+"1 2\r\n"+"1 2 3\r\n" + "1 2 3 4\r\n"+ "1 2 3 4 5\r\n"
            +"1 2 3 4\r\n"+"1 2 3\r\n"+"1 2\r\n"+"1";
        
        string result= Triangle.PrintTriangle(input);

        //Assert
        Assert.AreEqual(expextedresult, result);
    }
}
