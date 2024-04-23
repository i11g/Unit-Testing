using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        //// Arrange
        //string input = string.Empty;

        //// Act
        //string actual=StringReverse.Reverse(input);

        //// Assert
        //Assert.AreEqual("",actual);


        //Arrange
        string empty=string.Empty;
        //Act
        string result= StringReverse.Reverse(empty);
        //Assert
        Assert.That(result, Is.EqualTo(empty));

    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        //    //Arrange
        //    string input = "V"; 

        //    //Act 
        //    string result=StringReverse.Reverse(input);

        //    //Assert 
        //    Assert.AreEqual("V", result);
        //    Assert.AreEqual(1, result.Length);
        //}

        //Arrange
        string single = "p";
        //Act
        string result=StringReverse.Reverse(single);
        //Assert
        Assert.AreEqual("p", result);

    }
    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        ////Arrange 
        //string input = "XPNDT"; 

        ////Act 

        //string result=StringReverse.Reverse(input);


        ////Assert 

        //Assert.AreEqual("TDNPX", result);
        //Assert.AreEqual(input.Length, result.Length);

        //Arange
        string normal = "NovaTV";
        //Act
        string result=StringReverse.Reverse(normal);
        //Assert
        Assert.That(result, Is.EqualTo("VTavoN"));

    }
}
