using NUnit.Framework;

using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        
        string input = "Sofia";
        string expected = "aifoS";

        // Act
        //string result =input.ArgumentNullReverse("Sofia");
        string result=this._exceptions.ArgumentNullReverse(input);
    
        // Assert
        Assert.That(result, Is.EqualTo(expected));
     }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input= null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        //Exceptions price=new Exceptions();
        decimal totalPrice = 20.0m;
        decimal discount = 10.0m;

        //Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.That(result, Is.EqualTo(18));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange

        decimal totalPrice = 6.0m;
        decimal discount = -5.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        //Exceptions exceptions = new Exceptions();

        int[] input = new int[] { 1, 2, 3, 4 };
        int index = 3;
        //Act
        int result = this._exceptions.IndexOutOfRangeGetElement(input, index);
        //Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4 };
        int index = -3;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert

        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }


    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] input = { 1, 2, 10 };
        int index = 4;

        //Act&Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange

        bool isLoggedIn = true;

        //Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        //Assert
        Assert.That(result, Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        //Arrange
        bool isLoggedIn = false;

        //Act&Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Exceptions exceptions = new Exceptions();
        //Arrange
        string input = "67";
        //Act
        int result = this._exceptions.FormatExceptionParseInt(input);
        //Assert
        Assert.AreEqual(67, result);
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        //Arrange
        string input = "text";
        //Act&//Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        //Exceptions exceptions = new Exceptions();
        //Dictionary<string, int> input = new();
        //input.Add("67", 7);
        //string key = "67";

        //Arrange
        Dictionary<string, int> dictionary = new()
        {
            ["Pesho"] = 88,
            ["Gosho"] = 99,
            ["Tosho"] = 110,

        };
        string key = "Pesho";

        //Act

        dictionary[key] = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        //Assert
        Assert.That(dictionary[key], Is.EqualTo(88));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        ////Arrange
        //Dictionary<string,int> input=new();
        //input.Add("test", 90);
        Dictionary<string, int> dictionary = new()
        {
            ["888"] = 123,
            ["678"] = 345,
            ["876"] = 678,

        };

        string key = "111";
        //Act&Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        Exceptions equal = new Exceptions();
        int a = 5;
        int b = 9;
        //Act
        int result = equal.OverflowAddNumbers(a, b);
        //Assert
        Assert.That(result, Is.EqualTo(14));

    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MaxValue;
        int b = int.MaxValue;
        //Act&Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MinValue;
        int b = int.MinValue;

        //Act&Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange

        int num1 = 6;
        int num2 = 3;

        //Act
        int result = this._exceptions.DivideByZeroDivideNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange

        int num1 = 6;
        int num2 = 0;

        //Act&Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(num1, num2), Throws.InstanceOf<DivideByZeroException>());

    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange

        int[] num = new[] { 1, 2, 3 };
        int index = 2;

        //Act
        int result = this._exceptions.SumCollectionElements(num, index);

        //Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange

        int[] num = null;
        int index = 3;

        //Act&&Assert

        Assert.That(() => this._exceptions.SumCollectionElements(num, index), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] num = new[] { 1, 2, 3 };
        int index = 5;

        //Act&Assert
        Assert.That(() => this._exceptions.SumCollectionElements(num, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> collection = new Dictionary<string, string>()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3",
        };

        string key = "first";

        //Act
        int result = this._exceptions.GetElementAsNumber(collection, key);

        //Assert

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {

        Dictionary<string, string> collection = new Dictionary<string, string>()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3",
        };

        string key = "sixth";

        //Act&Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(collection, key), Throws.InstanceOf<KeyNotFoundException>());

    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> collection = new Dictionary<string, string>()
        {
            ["first"] = "1dgd",
            ["second"] = "222&&&",
            ["third"] = "3tgth",
        };

        string key = "first";

        //Act&Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(collection, key), Throws.InstanceOf<FormatException>());
    }
}
