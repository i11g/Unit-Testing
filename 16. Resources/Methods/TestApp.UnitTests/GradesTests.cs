using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    //[TestCase(3.50,"Good")]
    //[TestCase(4.50,"Very Good")]
    //[TestCase(5.00,"Exelent")]
    //[TestCase(4.00,"Very Good")]
    //[TestCase(2.00,"Fail")]
    [TestCase(3.10,"Average")]
    [TestCase(4.30,"Very Good")]
    [TestCase(3.30,"Average")]
    [TestCase(4.70,"Excellent")]
    [TestCase(2.50,"Fail")]

    public void Test_GradeAsWords_ReturnsCorrectString(double grade,string expected)
    {
        // Arrange
       
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    //[TestCase(0.00,"Invalid!")]
    //[TestCase(60.00,"Invalid!")]
    //[TestCase(-3.00,"Invalid!")]
    //[TestCase(1.00, "Invalid!")]
    //[TestCase(-100.00,"Invalid!")]

    [TestCase(0.00,"Invalid!")]
    [TestCase(100.00,"Invalid!")]
    [TestCase(-50.00,"Invalid!")]
    [TestCase(30.00,"Invalid!")]
    [TestCase(9.00,"Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
