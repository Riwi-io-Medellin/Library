using Library.Domain.Abstractions;
using Library.Domain.Enums;

namespace Library.Domain.Entities;

/// <summary>
/// Préstamo de un libro a un miembro. Depende de Book y Member (entidad hija).
/// </summary>
public class Loan : Entity
{
    public Guid BookId { get; private set; }
    public Guid MemberId { get; private set; }
    public DateTime LoanDate { get; private set; }
    public DateTime DueDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }
    public LoanStatus Status { get; private set; }

    public Loan(Book book, Member member, DateTime loanDate, DateTime dueDate)
    {
        BookId = book.Id;
        MemberId = member.Id;
        LoanDate = loanDate;
        DueDate = dueDate;
        Status = LoanStatus.Active;

        book.Lend();
    }

    public void Return(Book book, DateTime returnDate)
    {
        ReturnDate = returnDate;
        Status = LoanStatus.Returned;
        MarkAsUpdated();

        book.ReturnCopy();
    }
}
