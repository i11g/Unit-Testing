using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        //decimal money = 100;
        //List<int> initialQuality = new List<int>() { 10, 20, 30 };
        //List<string> commands = new List<string>() { "3", "5" };
        //Act & Assert
        //Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);

        //Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 5, 8, 20 };
        List<string> commands = new List<string>() { "1", "2", };
        //Act&Assert
        Assert.That( () => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);

    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        //decimal money = 100;
        //List<int> initialQuality = new List<int>() { 10, 20, 30 };
        //List<string> commands = new List<string>() { "string", "5", "Hit it again Gabsy!" };
        ////Act&Assert
        //Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 5, 8, 20 };
        List<string> commands = new List<string>() { "string", "2","Hit it again Gambsy!" };
        //Act&Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);

    }
    

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        ////Arrange
        //decimal pari = 100;
        //List<int> initialQuality = new List<int>() { 10, 20, 30 };
        //List<string> commands = new List<string>() { "3", "5", "Hit it again, Gabsy!" };
        //string expected= "2 12 22\nGabsy has 100.00lv.";

        ////Act
        //string result= DrumSet.Drum(pari,initialQuality,commands);
        ////
        //Assert.AreEqual(expected, result);
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 5, 8, 20 };
        List<string> commands = new List<string>() {"1", "2", "Hit it again, Gabsy!" };
        string expected = "2 5 17\nGabsy has 100.00lv.";
        //Act
        string result = DrumSet.Drum(money, initialQuality, commands);
        //Assert
        Assert.That(result,Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmountAndCorrectMoney()
    {
        //Arrange
        decimal pari = 100;
        List<int> initialQuality = new List<int>() { 10, 20, 30 };
        List<string> commands = new List<string>() { "8", "5", "Hit it again, Gabsy!" };
        string expected = "10 7 17\nGabsy has 70.00lv.";

        //Act
        string result = DrumSet.Drum(pari, initialQuality, commands);
        //
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal pari = 0;
        List<int> initialQuality = new List<int>() { 5, 20, 30 };
        List<string> commands = new List<string>() { "3", "5", "Hit it again, Gabsy!" };
        string expected = "12 22\nGabsy has 0.00lv.";

        //Act
        string result = DrumSet.Drum(pari, initialQuality, commands);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal pari = 5;
        List<int> initialQuality = new List<int>() { 5, 8, 4 };
        List<string> commands = new List<string>() { "3", "10", "Hit it again, Gabsy!" };
        string expected = "\nGabsy has 0.00lv.";
    }
}
