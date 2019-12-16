using System.Data.Entity;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LibraryManagementSystemContext : DbContext
    {
        public LibraryManagementSystemContext()
            : base("name=LibraryManagementSystemContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<UserBook> UserBooks { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
