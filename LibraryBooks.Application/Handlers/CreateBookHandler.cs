using LibraryBooks.Application.Requests;
using LibraryBooks.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Handlers
{
    public class CreateBookHandler(IBookRepository bookRepository) : IRequestHandler<CreateBookRequest>
    {
        private readonly IBookRepository _bookRepository = bookRepository;

        public async Task<Unit> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            await _bookRepository.AddAsync(new Domain.LibraryBook
            {
                Title = request.Title,
                Author = request.Author
            });
            return Unit.Value;
        }

        Task IRequestHandler<CreateBookRequest>.Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            return Handle(request, cancellationToken);
        }
    }
}
