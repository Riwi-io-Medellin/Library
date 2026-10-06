namespace Library.Domain.ValueObjects;

/// <summary>
/// Correo electrónico de un miembro.
/// Por ahora no valida nada: agregar las validaciones es parte del ejercicio.
/// </summary>
public sealed record Email
{
    public string Value { get; }

    public Email(string value)
    {
        Value = value;
    }
}
