using Library.Domain.Abstractions;
using Library.Domain.Enums;
using Library.Domain.ValueObjects;

namespace Library.Domain.Entities;

/// <summary>
/// Préstamo de un libro a un miembro. Depende de Book y Member (entidad hija).
/// </summary>
public class Loan : Entity
{
    public Guid BookId { get; private set; }
    public Guid MemberId { get; private set; }
    public LoanPeriod Period { get; private set; }
    public DateTime? ReturnDate { get; private set; }
    public LoanStatus Status { get; private set; }

    public Loan(Book book, Member member, LoanPeriod period)
    {
        BookId = book.Id;
        MemberId = member.Id;
        Period = period;
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
