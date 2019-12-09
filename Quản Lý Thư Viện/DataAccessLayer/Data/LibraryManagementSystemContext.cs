using DataTransferObject.Models;
using System.Data.Entity;

namespace DataAccessLayer.Data
{
    class LibraryManagementSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public LibraryManagementSystemContext() : base("name=LibraryManagementSystemContext")
        {
            // 
        }
    }
}
