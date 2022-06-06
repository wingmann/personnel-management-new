namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// Implements unique identifier.
/// </summary>
public class Id
{
    /// <summary>
    /// 
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// 
    /// </summary>
    public Id()
    {
        Value = Guid.NewGuid().ToString();
    }
}
