using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double result=earth.CalculateGravity(mass);

        // Assert
        Assert.That(result, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        //Arrange
        Planet venera = new Planet("Venera", 154647.00, 1000008.00, 4);
        
        string expected = $"Planet: Venera{Environment.NewLine}Diameter: 154647 km{Environment.NewLine}" +
            $"Distance from the Sun: 1000008 km{Environment.NewLine}Number of Moons: 4";
        
        //Act
        string result = venera.GetPlanetInfo();
        
        //Assert
        Assert.That (result, Is.EqualTo(expected));
    }
}
