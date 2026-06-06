using System.Text.RegularExpressions;

namespace RemoteAuthApp.Helpers;

public static class ValidationHelper
{
    public static bool IsValidEmail(string email)
        => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    public static bool IsNullOrWhiteSpace(params string[] values)
        => values.Any(string.IsNullOrWhiteSpace);
}
