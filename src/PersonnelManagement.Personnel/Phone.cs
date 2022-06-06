using System.Text;

namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// Implements phone number.
/// </summary>
public class Phone
{
    /// <summary>
    /// Phone number.
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="phone"></param>
    /// <exception cref="ArgumentException"></exception>
    public Phone(long phone)
    {
        Value = Validate(phone)
            ? phone.ToString()
            : throw new ArgumentException("Phone number is not correct.", nameof(phone));
    }

    /// <summary>
    /// 
    /// </summary>
    public void Change(long phone)
    {
        Value = Validate(phone)
            ? phone.ToString()
            : throw new ArgumentException("Phone number is not correct.", nameof(phone));
    }

    private static bool Validate(long phone) =>
        phone is >= 100_000_00_00 and <= 999_999_99_99;

    /// <summary>
    /// String representation of the phone number.
    /// </summary>
    /// <returns>Formatted phone number.</returns>
    public override string ToString() => new StringBuilder("+1 ")
        .Append(Value[0])
        .Append(Value[1])
        .Append(Value[2])
        .Append('-')
        .Append(Value[3])
        .Append(Value[4])
        .Append(Value[5])
        .Append('-')
        .Append(Value[6])
        .Append(Value[7])
        .Append(Value[8])
        .Append(Value[9])
        .ToString();
}
