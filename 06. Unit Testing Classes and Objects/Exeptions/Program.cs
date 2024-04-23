using System;
using System.Collections.Generic;
using System.Linq;


    static string ArgumentNullReverse(string? s)
    {
        if (s is null)
        {
            throw new ArgumentNullException(nameof(s), "String cannot be null.");
        }

        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
//string input = null;
//string result1 = ArgumentNullReverse(input);
//Console.WriteLine(result1);

static decimal ArgumentCalculateDiscount(decimal totalPrice, decimal discount)
    {
        if (discount is < 0 or > 100)
        {
            throw new ArgumentException("Discount must be between 0 and 100.", "discount");
        }

        return totalPrice - totalPrice * discount / 100;
    }
decimal totalPrice =20;
decimal discount = 5;
decimal result2 = ArgumentCalculateDiscount(totalPrice,discount);
Console.WriteLine(result2);

static int IndexOutOfRangeGetElement(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        return array[index];
    }

    static string InvalidOperationPerformSecureOperation(bool isLoggedIn)
    {
        if (!isLoggedIn)
        {
            throw new InvalidOperationException("User must be logged in to perform this operation.");
        }

        return "User logged in.";
    }

    static int FormatExceptionParseInt(string input)
    {
        if (!int.TryParse(input, out int result))
        {
            throw new FormatException("Input is not in the correct format for an integer.");
        }

        return result;
    }

    static int KeyNotFoundFindValueByKey(Dictionary<string, int> dictionary, string key)
    {
        if (!dictionary.ContainsKey(key))
        {
            throw new KeyNotFoundException("The specified key was not found in the dictionary.");
        }

        return dictionary[key];
    }

    static int OverflowAddNumbers(int a, int b)
    {
        try
        {
            return checked(a + b);
        }
        catch (OverflowException ex)
        {
            throw new OverflowException("Arithmetic overflow occurred during addition.", ex);
        }
    }

    static int DivideByZeroDivideNumbers(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return dividend / divisor;
    }

    static int SumCollectionElements(int[]? collection, int index)
    {
        if (collection is null)
        {
            throw new ArgumentNullException(nameof(collection), "Collection cannot be null.");
        }

        if (index < 0 || index >= collection.Length)
        {
            throw new IndexOutOfRangeException("Index has to be within bounds.");
        }

        return collection.Sum(n => n);
    }

    static int GetElementAsNumber(Dictionary<string, string> dictionary, string key)
    {
        if (!dictionary.ContainsKey(key))
        {
            throw new KeyNotFoundException("Key not found in the dictionary.");
        }

        string s = dictionary[key];
        int n;
        try
        {
            n = int.Parse(s);
        }
        catch (FormatException ex)
        {
            throw new FormatException("Can't parse string.", ex);
        }

        return n;
    }
  


