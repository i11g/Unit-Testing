using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        ////Arrange
        //string email = "ivv@abv.bg";
        ////Act
        //bool result= Email.IsValidEmail(email);
        ////Arrange
        //Assert.That(result, Is.True);

        //Arrange
        string valid = "ifr45@abv.bg";
        //Act
        bool result= Email.IsValidEmail(valid);
        Assert.That(result, Is.True);

    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        //Arrange
        string email = "ivv.abv.bg";
        //Act
        bool result= Email.IsValidEmail(email);
        //Assert
        Assert.That(result, Is.False);

    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {   
        //Arrange
        string email = null;
        //Act
        bool result= Email.IsValidEmail(email);
        //Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void Test_IsValidEmail_WhiteSpace()
    {
        //Arrange
        string email = " ";
        //Act
        bool result = Email.IsValidEmail(email);
        //Assert
        Assert.IsFalse(result);
    }
       

}
