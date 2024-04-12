﻿
using System.Text.RegularExpressions;

static bool IsValidEmail(string email)
{
    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    Regex regex = new(pattern);

    return regex.IsMatch(email);
}

string input = "exp@bg.com";
bool result=IsValidEmail(input);
Console.WriteLine(result);