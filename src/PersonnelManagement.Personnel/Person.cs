namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// Implements person.
/// </summary>
public class Person
{
    /// <inheritdoc cref="IPerson.Name" />
    public Name Name { get; private set; }
    
    /// <inheritdoc cref="IPerson.Email" />
    public Email Email { get; private set; }
    
    /// <inheritdoc cref="IPerson.Phone" />
    public Phone Phone { get; private set; }
    
    /// <inheritdoc cref="IPerson.Id" />
    public Id Id { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="email"></param>
    /// <param name="phone"></param>
    public Person(Name name, Email email, Phone phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Id = new Id();
    }
}
