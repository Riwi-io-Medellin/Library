using Library.Domain.Abstractions;

namespace Library.Domain.Entities;

/// <summary>
/// Libro del catálogo. Lleva la cuenta de las copias disponibles para prestar.
/// </summary>
public class Book : Entity
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int AvailableCopies { get; private set; }

    public Book(string title, string author, int availableCopies)
    {
        Title = title;
        Author = author;
        AvailableCopies = availableCopies;
    }

    public void Rename(string title)
    {
        Title = title;
        MarkAsUpdated();
    }

    // Solo lo llama Loan al crear un préstamo.
    internal void Lend()
    {
        AvailableCopies--;
        MarkAsUpdated();
    }

    // Solo lo llama Loan al devolver un préstamo.
    internal void ReturnCopy()
    {
        AvailableCopies++;
        MarkAsUpdated();
    }
}
