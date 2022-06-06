namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// Implements unique identifier.
/// </summary>
public class Id
{
    /// <summary>
    /// 
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// 
    /// </summary>
    public Id() => Value = Guid.NewGuid();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"@{Value.ToString()}";
}
