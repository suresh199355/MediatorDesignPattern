using LibraryBooks.Domain;
using MediatR;

namespace LibraryBooks.Application.Requests;

public class ReadBookRequest : IRequest<LibraryBook>
{
    public int BookId { get; set; }
}

