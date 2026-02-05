using LibraryBooks.Application.Requests;
using LibraryBooks.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Handlers;

public class UpdateBookHandler(IBookRepository bookRepository) : IRequestHandler<UpdateBookRequest>
{
    private readonly IBookRepository _bookRepository = bookRepository;
    public async Task<Unit> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
    {
        var existingBook = await _bookRepository.GetAsync(request.BookId);

        if (existingBook != null)
        {
            // Update book properties
            existingBook.Title = request.Title;
            existingBook.Author = request.Author;
            // Update other properties as needed

            await _bookRepository.UpdateAsync(request.BookId, existingBook);
        }

        return Unit.Value;
    }

    Task IRequestHandler<UpdateBookRequest>.Handle(UpdateBookRequest request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}
