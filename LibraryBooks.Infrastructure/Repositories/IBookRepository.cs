using LibraryBooks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Infrastructure.Repositories;

public interface IBookRepository
{
    Task<int> AddAsync(LibraryBook book);
    Task<LibraryBook> GetAsync(int bookId);
    Task UpdateAsync(int bookId, LibraryBook updatedBook);
    Task DeleteAsync(int bookId);
}
