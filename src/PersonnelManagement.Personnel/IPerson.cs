namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// 
/// </summary>
public interface IPerson
{
    /// <summary>
    /// Full name.
    /// </summary>
    Name Name { get; }
    
    /// <summary>
    /// Email address.
    /// </summary>
    Email Email { get; }
    
    /// <summary>
    /// Phone number.
    /// </summary>
    Phone Phone { get; }
    
    /// <summary>
    /// Unique identifier.
    /// </summary>
    Id Id { get; }
}
