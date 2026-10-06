using Library.Domain.Abstractions;

namespace Library.Domain.Entities;

/// <summary>
/// Persona inscrita en la biblioteca que puede pedir libros prestados.
/// </summary>
public class Member : Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Member(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void Rename(string name)
    {
        Name = name;
        MarkAsUpdated();
    }
}
