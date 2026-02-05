using MediatR;

namespace LibraryBooks.Application.Requests;

public class UpdateBookRequest : IRequest
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

