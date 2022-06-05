using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// 
/// </summary>
public class Email
{
    /// <summary>
    /// 
    /// </summary>
    public MailAddress Value { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <exception cref="InvalidDataException"></exception>
    public Email([NotNull] string email)
    {
        if (Validate(email))
        {
            Value = new MailAddress(email);
        }

        throw new InvalidDataException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <exception cref="InvalidDataException"></exception>
    public void Change([NotNull] string email)
    {
        if (Validate(email))
        {
            Value = new MailAddress(email);
        }

        throw new InvalidDataException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static bool Validate(string value)
    {
        Regex regex = new(
            @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            RegexOptions.CultureInvariant | RegexOptions.Singleline);

        return regex.IsMatch(value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() => Value.Address;
}
