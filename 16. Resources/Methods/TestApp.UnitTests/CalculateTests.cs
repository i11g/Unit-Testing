using NUnit.Framework;
using System.Globalization;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition_WhenParametersArePositive()
    {
        // Arrange
        Calculate calculator = new(); // ��������� ���� ��������� �� ����� �� �� ���� �� �������� �����, ����� �� � static
                                      // ���������� Calculate - ��� �� ����� � calculator ����� � ���� ����������
                                      // Act
        int actual = calculator.Addition(5, 2); // ����� ������������ calculator ������� ������

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly."); // �������� ��������� � ������� ��������
        Assert.Greater(actual, 0);
    }

    [Test]
    public void Test_Addition_WhenParametersAreNegative()
    {
        //Arrange
        Calculate calculator = new();
        //Act 
        int actual = calculator.Addition(-5, -2);
        // Assert
        Assert.AreEqual(actual, -7);
        Assert.Less(actual, 0);
    }


    [Test]
    public void Test_Subtraction_WhenParametersArePositive()
    {
        // Arrange
        Calculate calculator = new();
        // Act 
        int result = calculator.Subtraction(7, 4);
        //Assert
        Assert.AreEqual(3, result);
    }
    [Test]
    public void Test_Subtraction_WhenParametersAreNegative()
    {
        //Arrange
        Calculate calculator = new();

        //Act
        int result = calculator.Subtraction(-7, -5);
        //Assert
        Assert.AreEqual(-2,result);

         

    }

}
