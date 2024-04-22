using System.Net.Mail;

static bool IsValidEmail(string email)
{
    if (string.IsNullOrWhiteSpace(email))
    {
        return false;
    }

    return MailAddress.TryCreate(email, out _);
}
string email=Console.ReadLine();
bool result = IsValidEmail(email);
Console.WriteLine(result);