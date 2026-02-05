using LibraryBooks.Domain;

namespace LibraryBooks.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(LibraryBook book)
        {
            _context.LibraryBooks.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }

        public async Task DeleteAsync(int bookId)
        {
            var book = await _context.LibraryBooks.FindAsync(bookId);

            if (book != null)
            {
                _context.LibraryBooks.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<LibraryBook> GetAsync(int bookId)
        {
            var book = await _context.LibraryBooks.FindAsync(bookId);
            return book;
        }

        public async Task UpdateAsync(int bookId, LibraryBook updatedBook)
        {
            var existingBook = await _context.LibraryBooks.FindAsync(bookId);

            if (existingBook != null)
            {
                // Update properties
                existingBook.Title = updatedBook.Title;
                existingBook.Author = updatedBook.Author;
                // Update other properties as needed

                await _context.SaveChangesAsync();
            }
        }
    }
}
