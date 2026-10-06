# Ejercicio

Ahora mismo el dominio **no valida nada**: se puede prestar un libro sin copias o devolver un préstamo dos veces. Tu trabajo es agregar esas reglas, paso a paso.

## Parte 1: Errors

- [ ] Crear `Error` (código y mensaje) con constructor clásico.
- [ ] Crear un catálogo por entidad: `BookErrors`, `LoanErrors` y `MemberErrors`.
  - Pista: métodos estáticos que devuelven un `Error`. Los códigos siguen el formato `Entidad.Problema`.
- [ ] Errores sugeridos:
  - [ ] No hay copias disponibles.
  - [ ] El préstamo ya fue devuelto.
  - [ ] La fecha límite es anterior a la del préstamo (pista: valídalo en `LoanPeriod`).
  - [ ] El email no es válido.
  - [ ] El título o el nombre están vacíos.

## Parte 2: Exceptions

- [ ] Crear `DomainException`, que hereda de `Exception` y lleva un `Error`.
- [ ] Agregar las validaciones al dominio usando los errores de la parte 1.
  - Pista: valida en constructores y métodos, antes de cambiar el estado.

## Parte 3: Events

- [ ] Crear `IDomainEvent` y `AggregateRoot` (con la lista de eventos, `RaiseDomainEvent` y `ClearDomainEvents`).
- [ ] Hacer que `Loan` sea `AggregateRoot`.
- [ ] Anunciar `BookLoaned` al crear un préstamo y `BookReturned` al devolverlo.

## Parte 4: Application

- [ ] Instalar `Microsoft.Extensions.DependencyInjection.Abstractions` y crear `DependencyInjection.AddApplication()`.
- [ ] Interfaces de repositorio en `Interfaces/`.
  - Pista: `CancellationToken` en los métodos asíncronos y un `SaveChangesAsync`.
- [ ] DTOs por entidad en subcarpetas (`Books/`, `Members/`, `Loans/`).
  - Pista: `Request` como `sealed class` con DataAnnotations; `Response` como `sealed record`.
- [ ] Servicios:
  - [ ] Crear y consultar libros.
  - [ ] Crear y consultar miembros.
  - [ ] Prestar un libro y devolverlo.
  - [ ] Lanzar `NotFoundException` cuando lo buscado no existe.
- [ ] Registrar los servicios en `AddApplication()`.

## Recuerda

- **Error** describe el problema, **Exception** detiene la operación, **Event** avisa que algo sí pasó.
- Pregunta guía: *¿esto lo diría el dueño del negocio?* Sí → es una regla del dominio. No → es un fallo técnico.

## Checklist

- [ ] `dotnet build` compila sin errores.
- [ ] Ninguna propiedad de las entidades se puede modificar desde fuera.
- [ ] Cada validación del dominio usa un `Error` de su catálogo.
- [ ] Los códigos de error siguen el formato `Entidad.Problema`.
- [ ] Los eventos están en pasado (`BookLoaned`, no `LoanBook`).
- [ ] La API nunca recibe ni devuelve entidades, solo DTOs.

## Retos extra (opcionales)

- [ ] Un miembro no puede tener más de 3 préstamos activos.
- [ ] Marcar como vencido un préstamo que pasó su `DueDate`.
- [ ] Patrón `Result`: en lugar de lanzar `DomainException` para errores esperados (como "no hay copias"), devolverlos en un `Result`, y dejar las excepciones solo para bugs.
  - Pregunta guía: *¿el que llama debería esperar este caso y manejarlo?* Sí → `Result`. No → `Exception`.
- [ ] Pruebas unitarias del dominio con xUnit.
