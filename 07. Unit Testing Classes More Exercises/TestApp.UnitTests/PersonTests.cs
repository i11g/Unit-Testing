using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]

    public void SetUp()
    {
        this._person = new ();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };

        List<Person> expectedPeopleList = new List<Person>()
        {
            new Person
            {
                Name="Alice",
                Id="A001",
                Age=35
            },
            new Person
            {
                Name="Bob",
                Id="B002",
                Age=30
            }
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert

        Assert.That(resultPeopleList, Has.Count.EqualTo(2));

        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }
    [Test] 

    public void Test_AddPeople_ReturnsEmptyListWhenNoDataIsGiven()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        List<Person> expected = new List<Person> { };
        //Act
        List<Person> result = this._person.AddPeople(input);
        //Assert
        Assert.AreEqual(expected,result);

    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        //Arrange
        List<Person> people = new List<Person>()
        {
            new Person
            {
                Name="Alice",
                Id="1",
                Age=25

            },
            new Person
            {
                Name="Pesho",
                Id="2",
                Age=40
            },
            new Person
            {
                Name="Gosho",
                Id="3",
                Age=50

            }
        };
        string expected = $"Alice with ID: 1 is 25 years old.{Environment.NewLine}Pesho with ID: 2 is 40 years old." +
            $"{Environment.NewLine}Gosho with ID: 3 is 50 years old.";
        //Act
        string result = this._person.GetByAgeAscending(people);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test] 

    public void Test_GetByAgeAscending_ReturnsEmptyString_WhenNoDataIsGiven()
    {
        //Arrange
        List<Person> people = new() { };
        //Act
        string result = this._person.GetByAgeAscending(people);
        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}
