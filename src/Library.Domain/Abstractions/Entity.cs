namespace Library.Domain.Abstractions;

/// <summary>
/// Base de todas las entidades: identidad y datos de auditoría.
/// <list type="bullet">
///   <item><c>Id</c>, <c>CreatedAt</c> y <c>UpdatedAt</c> los asigna el dominio (fechas en UTC).</item>
///   <item><c>CreatedBy</c> y <c>UpdatedBy</c> los asignará la infraestructura al guardar.</item>
///   <item>Toda entidad debe llamar a <c>MarkAsUpdated()</c> cada vez que cambie su estado.</item>
/// </list>
/// </summary>
public abstract class Entity
{
    public Guid Id { get; private init; } = Guid.CreateVersion7();
    public DateTime CreatedAt { get; private init; } = DateTime.UtcNow;
    public Guid? CreatedBy { get; private init; }
    public DateTime? UpdatedAt { get; private set; }
    public Guid? UpdatedBy { get; private set; }

    protected void MarkAsUpdated()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}
