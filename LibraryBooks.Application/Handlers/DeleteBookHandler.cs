using LibraryBooks.Application.Requests;
using LibraryBooks.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Handlers;

public class DeleteBookHandler(IBookRepository bookRepository) : IRequestHandler<DeleteBookRequest>
{
    private readonly IBookRepository _bookRepository = bookRepository;
    public async Task<Unit> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
    {
        await _bookRepository.DeleteAsync(request.BookId);
        return Unit.Value;
    }

    Task IRequestHandler<DeleteBookRequest>.Handle(DeleteBookRequest request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}
