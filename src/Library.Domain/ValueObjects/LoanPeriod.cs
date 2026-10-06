namespace Library.Domain.ValueObjects;

/// <summary>
/// Periodo de un préstamo: desde cuándo y hasta cuándo.
/// Por ahora no valida nada: agregar las validaciones es parte del ejercicio.
/// </summary>
public sealed record LoanPeriod
{
    public DateTime LoanDate { get; }
    public DateTime DueDate { get; }

    public LoanPeriod(DateTime loanDate, DateTime dueDate)
    {
        LoanDate = loanDate;
        DueDate = dueDate;
    }
}
