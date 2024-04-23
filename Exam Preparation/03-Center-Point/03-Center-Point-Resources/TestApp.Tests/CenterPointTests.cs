using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        ////Arrange 
        //double pointOnex1 = 1;
        //double pointOney1 = 1;
        //double pointTwox1 = 2;
        //double pointTwoy1 = 2;
        ////Act
        //string result = CenterPoint.GetClosest(pointOnex1,pointOney1,pointTwox1,pointTwoy1);
        ////Assert
        //Assert.AreEqual("(1, 1)", result);

        //Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = 3;
        double y2 = 5;
        //Act
        string result= CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result,Is.EqualTo("(1, 2)"));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        ////Arrange 
        //double pointOnex1 = 2;
        //double pointOney1 = 2;
        //double pointTwox1 = 1;
        //double pointTwoy1 = 0.5;
        ////Act
        //string result = CenterPoint.GetClosest(pointOnex1, pointOney1, pointTwox1, pointTwoy1);
        ////Assert
        //Assert.AreEqual("(1, 0.5)", result);
        
        //Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = 0.5;
        double y2 = 0.5;
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.AreEqual("(0.5, 0.5)",result);

    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        ////Arrange 
        //double pointOnex1 = 5;
        //double pointOney1 = 5;
        //double pointTwox1 = 5;
        //double pointTwoy1 = 5;
        ////Act
        //string result = CenterPoint.GetClosest(pointOnex1, pointOney1, pointTwox1, pointTwoy1);
        ////Assert
        //Assert.AreEqual("(5, 5)", result);

        //Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = 1;
        double y2 = 2;
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.That(result, Is.EqualTo("(1, 2)"));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        ////Arrange 
        //double pointOnex1 = -3;
        //double pointOney1 = 1;
        //double pointTwox1 = 2;
        //double pointTwoy1 = 2;
        ////Act
        //string result = CenterPoint.GetClosest(pointOnex1, pointOney1, pointTwox1, pointTwoy1);
        ////Assert
        //Assert.AreEqual("(-3, 1)", result);

        //Arrange
        double x1 = -1;
        double y1 = 2;
        double x2 = 1;
        double y2 = 2;
        //Act
        string result= CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.AreEqual("(-1, 2)", result);

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        ////Arrange 
        //double pointOnex1 = 2;
        //double pointOney1 = 1;
        //double pointTwox1 =-1;
        //double pointTwoy1 =2;
        ////Act
        //string result = CenterPoint.GetClosest(pointOnex1, pointOney1, pointTwox1, pointTwoy1);
        ////Assert
        //Assert.AreEqual("(-1, 2)", result);

        //Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = -1;
        double y2 = 2;
        //Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);
        //Assert
        Assert.AreEqual("(-1, 2)", result);
    }
}
