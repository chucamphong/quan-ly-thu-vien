using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    class LibraryManagementSystemContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
