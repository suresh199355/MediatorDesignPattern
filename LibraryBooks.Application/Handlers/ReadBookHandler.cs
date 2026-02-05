using LibraryBooks.Application.Requests;
using LibraryBooks.Domain;
using LibraryBooks.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Handlers;

public class ReadBookHandler(IBookRepository bookRepository) : IRequestHandler<ReadBookRequest, LibraryBook>
{
    private readonly IBookRepository _bookRepository = bookRepository;
    public async Task<LibraryBook> Handle(ReadBookRequest request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetAsync(request.BookId);
        return book;
    }
}

