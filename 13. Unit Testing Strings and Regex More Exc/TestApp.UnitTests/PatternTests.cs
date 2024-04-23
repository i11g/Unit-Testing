using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    
    [TestCase("Sofia,Varna", 2, "sOfIa,vArNasOfIa,vArNa")]
    [TestCase("Sofia",3, "sOfIasOfIasOfIa")]
    [TestCase("sofia",1, "sOfIa")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = string.Empty;
        int rep = 2;
        //Act.Assert
        Assert.That(()=>Pattern.GeneratePatternedString(input,rep), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "Sofia";
        int rep = -2;
        //Act&Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, rep), Throws.ArgumentException);

    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "Sofia";
        int rep = 0;
        //Assert&Act
        Assert.That(() => Pattern.GeneratePatternedString(input, rep), Throws.ArgumentException);
    }
}
