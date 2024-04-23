using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
   
    [TestCase("Sofia",2, "sOfIasOfIa")]
    [TestCase("SofiaPleven",3, "sOfIaPlEvEnsOfIaPlEvEnsOfIaPlEvEn")]
    [TestCase("Sofia",1, "sOfIa")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
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
        int repetition = 3;
        //Act&Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetition), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "Sofia";
        int repetition = -5;
        Assert.That(()=>Pattern.GeneratePatternedString(input,repetition),Throws.ArgumentException);
        
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "Sofia";
        int repetition = 0;
        Assert.That(() => Pattern.GeneratePatternedString(input, repetition), Throws.ArgumentException);

    }
}
