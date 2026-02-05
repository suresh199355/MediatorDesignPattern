// To fix CS0234, ensure you have installed the Microsoft.EntityFrameworkCore NuGet package.
// In Visual Studio, right-click your project > Manage NuGet Packages > Browse > search for "Microsoft.EntityFrameworkCore" and install it.
// Or run the following command in the Package Manager Console:
// Install-Package Microsoft.EntityFrameworkCore

using LibraryBooks.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryBooks.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<LibraryBook> LibraryBooks { get; set; }
}

