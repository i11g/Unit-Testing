using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("abc@bg.com")]
    [TestCase("bob@abv.com")]
    [TestCase("ghgt@gogle.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange
        

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("a@com.com.bg/")]
    [TestCase("@pfgt.")]
    [TestCase("pofp.com@com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
