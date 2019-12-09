using DataTransferObject.Models;
using System.Data.Entity;

namespace DataAccessLayer.Data
{
    class LibraryManagementSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public LibraryManagementSystemContext() : base("name=LibraryManagementSystemContext")
        {
            // 
        }
    }
}
