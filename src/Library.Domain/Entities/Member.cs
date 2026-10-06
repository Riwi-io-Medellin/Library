using Library.Domain.Abstractions;
using Library.Domain.ValueObjects;

namespace Library.Domain.Entities;

/// <summary>
/// Persona inscrita en la biblioteca que puede pedir libros prestados.
/// </summary>
public class Member : Entity
{
    public string Name { get; private set; }
    public Email Email { get; private set; }

    public Member(string name, Email email)
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
