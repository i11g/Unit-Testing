﻿using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]

    public void  SetUp ()
    {
        this._vehicles=new ();
    }
      
    
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = 
        {

            "Cars/Ford/Focus/120",
            "Cars/Toyota/Camry/150",
            "Truck/Volvo/VNL/500"
        };
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}" +
            $"Toyota: Camry - 150hp{Environment.NewLine}" +
            $"Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        string expected =$"Cars:{Environment.NewLine}Trucks:";
        //Act
        string result=this._vehicles.AddAndGetCatalogue(input);
        //Assert
        Assert.AreEqual(expected,result);
    }

    [Test] 

    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue_WhenNoDataTruksAreGiven()
    {
        //Arrange

        string[] input =
        {
            "Cars/Ford/Focus/120",
            "Cars/Toyota/Camry/150",
        };
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}" +
            $"Toyota: Camry - 150hp{Environment.NewLine}" +
            $"Trucks:";
        //Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        //Assert
        Assert.AreEqual(expected,result);

    }

    [Test]

    public void Test__AddAndGetCatalogue_ReturnsSortedCatalogue_WhenNoDataCarsAreGiven()
    {
        //Arrange
        string[] input =
        {
            "Truck/Volvo/VNL/500"
        };
        string expected = $"Cars:{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        //Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        //Assert

        Assert.AreEqual(expected,result);

    }
}
