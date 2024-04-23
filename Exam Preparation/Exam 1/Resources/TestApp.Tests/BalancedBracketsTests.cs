using System;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        //Arrange
        string[] input=Array.Empty<string>();
        //Act
        bool result= BalancedBrackets.IsBalanced(input);
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] input = new string[] { "(", ")", "(", ")" };
        //Act
        bool result = BalancedBrackets.IsBalanced(input);
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] { "(", ")", "("};
        //Act
        bool result = BalancedBrackets.IsBalanced(input);
        //Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] { "(", ")", "(",")",")",")" };
        //Act
        bool result = BalancedBrackets.IsBalanced(input);
        //Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = new string[] {"(", "(", "("};
        //Act
        bool result = BalancedBrackets.IsBalanced(input);
        //Assert
        Assert.That(result, Is.False);
    }
}
